using Api;
using Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ProfitBricksSDK.Tests
{
    [TestClass]
    public class VolumeApiTest
    {
        DataCenterApi dcApi = new DataCenterApi(Config.Configuration);
        ServerApi serverApi = new ServerApi(Config.Configuration);
        VolumeApi volumeApi = new VolumeApi(Config.Configuration);
        AttachedVolumesApi attachedVolumesApi = new AttachedVolumesApi(Config.Configuration);
        SnapshotApi snapshotApi = new SnapshotApi(Config.Configuration);
        static Datacenter datacenter;
        static Volume volume;
        static Snapshot snapshot;
        static string instanceType = "volume";

        [TestMethod]
        public void VolumeCreate()
        {
            var sourceImage = TestHelper.GetImage("Ubuntu-16", "HDD", Config.DefaultLocation);
            Assert.IsNotNull(sourceImage);

            datacenter = TestHelper.CreateDatacenter();

            var sshKeys = new List<string> { "ssh-rsa AAAAB3NzaC1" };
            volume = new Volume
            {
                Properties = new VolumeProperties
                {
                    Name = Config.DefaultName,
                    Size = 2,
                    Bus = "VIRTIO",
                    Type = "HDD",
                    Image = sourceImage.Id,
                    AvailabilityZone = "ZONE_3",
                    SshKeys = sshKeys
                }
            };
            volume = volumeApi.Create(datacenter.Id, volume, depth: 5);
            Assert.IsNotNull(volume);
            Config.DoWait(volume.Request);

            Assert.AreEqual(instanceType, volume.Type);
            Assert.AreEqual(Config.DefaultName, volume.Properties.Name);
            Assert.AreEqual(2, volume.Properties.Size);
            Assert.AreEqual("VIRTIO", volume.Properties.Bus);
            Assert.AreEqual("HDD", volume.Properties.Type);
            Assert.AreEqual("ZONE_3", volume.Properties.AvailabilityZone);
            Assert.AreEqual(sourceImage.Id, volume.Properties.Image);
            Assert.IsTrue(volume.Properties.SshKeys.SequenceEqual(sshKeys));
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void VolumeCreateFail()
        {
            try
            {
                var req = new Volume
                {
                    Properties = new VolumeProperties
                    {
                        Name = Config.DefaultName
                    }
                };
                volumeApi.Create(datacenter.Id, req);
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(string.Format(Config.MissingAttributeError, "size")));
                throw;
            }
        }


        [TestMethod]
        public void VolumeGet()
        {
            var resp = volumeApi.FindById(datacenter.Id, volume.Id);

            Assert.AreEqual(volume.Id, resp.Id);
            Assert.AreEqual(volume.Type, resp.Type);
            Assert.AreEqual(volume.Properties.Name, resp.Properties.Name);
            Assert.AreEqual(volume.Properties.Size, resp.Properties.Size);
            Assert.AreEqual(volume.Properties.Type, resp.Properties.Type);
            Assert.AreEqual(volume.Properties.AvailabilityZone, resp.Properties.AvailabilityZone);
            Assert.AreEqual(volume.Properties.Image, resp.Properties.Image);
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void VolumeGetFail()
        {
            try
            {
                volumeApi.FindById(datacenter.Id, "00000000-0000-0000-0000-000000000000");
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(Config.NotFoundError));
                throw;
            }
        }

        [TestMethod]
        public void VolumeList()
        {
            var list = volumeApi.FindAll(datacenter.Id);

            Assert.IsTrue(list.Items.Count > 0);
            Assert.AreEqual(instanceType, list.Items[0].Type);
        }

        [TestMethod]
        public void VolumeUpdate()
        {
            var newName = Config.DefaultName + " - RENAME";
            var req = new Volume
            {
                Properties = new VolumeProperties { Name = newName, Size = 5 }
            };

            var newVolume = volumeApi.Update(datacenter.Id, volume.Id, req);
            Config.DoWait(newVolume.Request);

            Assert.AreEqual(newName, newVolume.Properties.Name);
            Assert.AreEqual(5, newVolume.Properties.Size);
        }

        [TestMethod]
        public void VolumeSnapshotCreate()
        {
            snapshot = volumeApi.CreateSnapshot(datacenter.Id, volume.Id, Config.DefaultName, ".NET SDK test snapshot");
            Config.DoWait(snapshot.Request);
            Assert.IsNotNull(snapshot);
            Assert.AreEqual("snapshot", snapshot.Type);
            Assert.AreEqual(Config.DefaultName, snapshot.Properties.Name);
            Thread.Sleep(90000);
        }

        [TestMethod]
        public void VolumeSnapshotRestore()
        {
            var resp = volumeApi.RestoreSnapshot(datacenter.Id, volume.Id, snapshot.Id);
            Assert.IsNull(resp);
            Thread.Sleep(60000);
        }

        [TestMethod]
        public void VolumeSnapshotDelete()
        {
            var response = snapshotApi.Delete(snapshot.Id);
            Assert.IsNull(response);
            Thread.Sleep(30000);
        }

        [TestMethod]
        public void VolumeDelete()
        {
            var response = volumeApi.Delete(datacenter.Id, volume.Id);
            Assert.IsNull(response);

            response = dcApi.Delete(datacenter.Id);
            Assert.IsNull(response);
        }
    }
}

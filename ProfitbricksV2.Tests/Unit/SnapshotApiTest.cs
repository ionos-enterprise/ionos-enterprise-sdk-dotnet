using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client;
using Model;
using Api;
using System.Threading;
using System.Linq;

namespace ProfitBricksSDK.Tests
{
    [TestClass]
    public class SnapshotApiTest
    {
        IDataCenterApi dcApi = new DataCenterApi(Config.Configuration);
        IVolumeApi volumeApi = new VolumeApi(Config.Configuration);
        SnapshotApi snapshotApi = new SnapshotApi(Config.Configuration);
        static Datacenter datacenter;
        static Volume volume;
        static Snapshot snapshot;
        static string instanceType = "snapshot";

        [TestMethod]
        public void SnapshotCreate()
        {
            datacenter = new Datacenter
            {
                Properties = new DatacenterProperties
                {
                    Name = Config.DefaultName,
                    Location = Config.DefaultLocation
                },
                Entities = new DatacenterEntities
                {
                    Volumes = TestHelper.BuildVolumes()
                }
            };

            datacenter = dcApi.Create(datacenter, depth: 1);
            Config.DoWait(datacenter.Request);

            volume = datacenter.Entities.Volumes.Items[0];

            snapshot = volumeApi.CreateSnapshot(datacenter.Id, volume.Id, Config.DefaultName, ".NET SDK test snapshot");
            Config.DoWait(snapshot.Request);
            Assert.IsNotNull(snapshot);
            Assert.AreEqual(instanceType, snapshot.Type);
            Assert.AreEqual(Config.DefaultName, snapshot.Properties.Name);
            Assert.AreEqual(".NET SDK test snapshot", snapshot.Properties.Description);
            Thread.Sleep(120000);
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void SnapshotCreateFail()
        {
            try
            {
                volumeApi.CreateSnapshot(datacenter.Id, "00000000-0000-0000-0000-000000000000");
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(Config.NotFoundError));
                throw;
            }
        }

        [TestMethod]
        public void SnapshotList()
        {
            var list = snapshotApi.FindAll();

            Assert.IsTrue(list.Items.Count > 0);
            Assert.AreEqual(instanceType, list.Items[0].Type);
        }

        [TestMethod]
        public void SnapshotGet()
        {
            volume = volumeApi.FindAll(datacenter.Id, depth: 5).Items[0];
            var resp = snapshotApi.FindById(snapshot.Id);

            Assert.AreEqual(snapshot.Id, resp.Id);
            Assert.AreEqual(snapshot.Type, resp.Type);
            Assert.AreEqual(snapshot.Properties.Name, resp.Properties.Name);
            Assert.AreEqual(snapshot.Properties.Description, resp.Properties.Description);
            Assert.AreEqual(snapshot.Properties.CpuHotPlug, volume.Properties.CpuHotPlug);
            Assert.AreEqual(snapshot.Properties.CpuHotUnplug, volume.Properties.CpuHotUnplug);
            Assert.AreEqual(snapshot.Properties.DiscScsiHotPlug, volume.Properties.DiscScsiHotPlug);
            Assert.AreEqual(snapshot.Properties.DiscScsiHotUnplug, volume.Properties.DiscScsiHotUnplug);
            Assert.AreEqual(snapshot.Properties.DiscVirtioHotPlug, volume.Properties.DiscVirtioHotPlug);
            Assert.AreEqual(snapshot.Properties.DiscVirtioHotUnplug, volume.Properties.DiscVirtioHotUnplug);
            Assert.AreEqual(snapshot.Properties.Location, Config.DefaultLocation);
            Assert.AreEqual(snapshot.Properties.RamHotPlug, volume.Properties.RamHotPlug);
            Assert.AreEqual(snapshot.Properties.RamHotUnplug, volume.Properties.RamHotUnplug);
            Assert.AreEqual(snapshot.Properties.NicHotPlug, volume.Properties.NicHotPlug);
            Assert.AreEqual(snapshot.Properties.NicHotUnplug, volume.Properties.NicHotUnplug);
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void SnapshotGetFail()
        {
            try
            {
                snapshotApi.FindById("00000000-0000-0000-0000-000000000000");
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(Config.NotFoundError));
                throw;
            }
        }

        [TestMethod]
        public void SnapshotUpdate()
        {
            var req = new SnapshotProperties
            {
                Name = snapshot.Properties.Name + " - RENAME",
                Description = snapshot.Properties.Description + " - RENAME"
            };
            var updated = snapshotApi.PartialUpdate(snapshot.Id, req);

            Assert.AreEqual(snapshot.Properties.Name + " - RENAME", updated.Properties.Name);
            Assert.AreEqual(snapshot.Properties.Description + " - RENAME", updated.Properties.Description);
        }

        [TestMethod]
        public void SnapshotDelete()
        {
            var resp = snapshotApi.Delete(snapshot.Id);
            Assert.IsNull(resp);
            resp = dcApi.Delete(datacenter.Id);
            Assert.IsNull(resp);
        }
    }
}

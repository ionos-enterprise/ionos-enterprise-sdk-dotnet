using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client;
using Model;
using Api;
using System.Threading;
using System.Linq;

namespace ProfitbricksV2.Tests
{
    [TestClass]
    public class SnapshotApiTest
    {
        Configuration configuration;
        IDataCenterApi dcApi;
        IVolumeApi volumeApi;
        ISnapshotApi snapshotApi;
        static Datacenter datacenter;
        static Volume volume;
        static Snapshot snapshot;

        private void Configure()
        {
            configuration = new Configuration
            {
                Username = "test@stackpointcloud.com",
                Password = "pwd",
            };

            dcApi = new DataCenterApi(configuration);
            volumeApi = new VolumeApi(configuration);
            snapshotApi = new SnapshotApi(configuration);
            //Create a datacenter.
            if (datacenter == null)
            {
                datacenter = new Datacenter
                {
                    Properties = new DatacenterProperties
                    {
                        Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString(),
                        Description = "Unit test for .Net SDK PB REST V2",
                        Location = "us/lasdev"
                    }
                };

                datacenter = dcApi.Create(datacenter);
            }

            if (volume == null)
            {
                volume = new Volume
                {
                    Properties = new VolumeProperties
                    {
                        Size = 1,
                        LicenceType = "LINUX",
                        Type = "HDD",
                        Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString(),
                    }
                };
                volume = volumeApi.Create(datacenter.Id, volume);
                DoWait(volume.Request);
            }
        }

        [TestMethod]
        public void SnapshotCreate()
        {
            Configure();
            var resp = volumeApi.CreateSnapshot(datacenter.Id, volume.Id, "Test Snapshot", "Snapshot Description");

            Assert.IsNull(resp.Messages);
        }

        [TestMethod]
        public void SnapshotList()
        {
            Configure();
            var list = snapshotApi.FindAll(depth: 5);

            Assert.IsTrue(list.Items.Count > 0);
            snapshot = list.Items.FirstOrDefault();
        }

        [TestMethod]
        public void SnapshotGet()
        {
            Configure();
            var snapsht = snapshotApi.FindById(snapshot.Id);

            Assert.AreEqual(snapsht.Id, snapshot.Id);
            Assert.AreEqual(snapsht.Properties.Name, snapshot.Properties.Name);
        }

        [TestMethod]
        public void SnapshotUpdate()
        {
            Configure();
            var updated = snapshotApi.PartialUpdate(snapshot.Id, new SnapshotProperties { Name = snapshot.Properties.Name + " -Updated" });

            Assert.AreEqual(updated.Properties.Name, snapshot.Properties.Name + " -Updated");
        }

        [TestMethod]
        public void RestoreSnapshot()
        {
            Configure();
            var resp = volumeApi.RestoreSnapshot(datacenter.Id, snapshot.Id);

            Assert.IsNull(resp);
        }

        [TestMethod]
        public void SnapshotDelete()
        {
            Configure();
            var resp = snapshotApi.Delete(snapshot.Id);
            resp = dcApi.Delete(datacenter.Id);
            Assert.IsNull(resp);
        }

        private void DoWait(string requestUrl)
        {
            if (string.IsNullOrEmpty(requestUrl))
                return;
            var requestApi = new RequestApi(configuration);

            var sub = requestUrl.Substring(requestUrl.IndexOf("requests/") + 9, 36);
            var request = new RequestStatus();
            int counter = 0;

            do
            {
                request = requestApi.GetStatus(sub);
                counter++;
                Thread.Sleep(1000);
                if (counter == 35)
                    break;
                else if (request.Metadata.Status == "FAILED")
                    throw new Exception(request.Metadata.Message);
            } while (request.Metadata.Status != "DONE" && counter != 35);
        }

    }
}

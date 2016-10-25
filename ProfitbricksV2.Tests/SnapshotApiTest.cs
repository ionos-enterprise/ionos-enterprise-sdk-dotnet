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
        IDataCenterApi dcApi = new DataCenterApi(Config.Configuration);
        IVolumeApi volumeApi = new VolumeApi(Config.Configuration);
        ISnapshotApi snapshotApi = new SnapshotApi(Config.Configuration);
        static Datacenter datacenter;
        static Volume volume;
        static Snapshot snapshot;

        [TestInitialize]
        public void SnapshotCreate()
        {
            //Create a datacenter.
            if (datacenter == null)
            {
                datacenter = new Datacenter
                {
                    Properties = new DatacenterProperties
                    {
                        Name = ".Net V2 - SNAPSHOT Test " + DateTime.Now.ToShortTimeString(),
                        Description = "Unit test for .Net SDK PB REST V2",
                        Location = "us/las"
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
               Config.DoWait(volume.Request);
            }

            var resp = volumeApi.CreateSnapshot(datacenter.Id, volume.Id, "Test Snapshot", "Snapshot Description");
            Assert.IsNull(resp.Messages);
        }

        [TestMethod]
        public void SnapshotList()
        {
            var list = snapshotApi.FindAll(depth: 5);

            Assert.IsTrue(list.Items.Count > 0);
            snapshot = list.Items.FirstOrDefault();
        }

        [TestMethod]
        public void SnapshotGet()
        {
            var snapsht = snapshotApi.FindById(snapshot.Id);

            Assert.AreEqual(snapsht.Id, snapshot.Id);
            Assert.AreEqual(snapsht.Properties.Name, snapshot.Properties.Name);
        }

        [TestMethod]
        public void SnapshotUpdate()
        {
            var updated = snapshotApi.PartialUpdate(snapshot.Id, new SnapshotProperties { Name = snapshot.Properties.Name + " -Updated" });

            Assert.AreEqual(updated.Properties.Name, snapshot.Properties.Name + " -Updated");
        }

        [TestMethod]
        public void RestoreSnapshot()
        {
            var resp = volumeApi.RestoreSnapshot(datacenter.Id, snapshot.Id);

            Assert.IsNull(resp);
        }

        [TestCleanup]
        public void SnapshotDelete()
        {
            var resp = snapshotApi.Delete(snapshot.Id);
            resp = dcApi.Delete(datacenter.Id);
            Assert.IsNull(resp);
        }
    }
}

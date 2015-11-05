using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProfitBricks.Client;
using ProfitBricks.Client.Resources;
using ProfitBricks.POCO;
using ProfitBricks.POCO.Enums;
using ProfitBricks.POCO.Requests;
using ProfitBricks.POCO.Responses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
namespace ProfitBrickUnitTests
{
    [TestClass]
    public class SnapshotTests
    {
        private static string storageId;
        private static string snapshotId;
        Snapshots snapshotsApi = ProfitBricksSoapClient.Instance().Snapshots;

        #region Snapshot

        [ClassInitialize()]
        public static void Initialize(TestContext testContext)
        {
            var volumes = ProfitBricksSoapClient.Instance().Volumes.Get();

            Assert.IsNotNull(volumes, "At least one Volume is require to Snapshots Storages");
            storageId = volumes.FirstOrDefault().StorageId;
        }

        [TestMethod]
        public void CreateSnapshot()
        {
            var request = new CreateSnapshotRequest();

            request.StorageId = storageId;
            request.SnapshotName = "snapshot 1";
            request.Description = "describing the snashot";

            var response = snapshotsApi.Create(request);

            Assert.IsNotNull(response);

            snapshotId = response.Id;
        }

        [TestMethod]
        public void GetOneSnapshot()
        {
            var snapshot = (Snapshot)snapshotsApi.Show(snapshotId);

            Assert.IsNotNull(snapshot);
        }
        [TestMethod]
        public void GetAllSnapshots()
        {
            var snapshots = snapshotsApi.Get();

            Assert.IsNotNull(snapshots);
        }


        [TestMethod]
        public void UpdateSnapshot()
        {
            UpdateSnapshotRequest request = new UpdateSnapshotRequest
            {
                SnapshotId = snapshotId,
                Description = "new description",
                SnapshotName = "new name"
            };
            
            snapshotsApi.Update(request);

            var result = (Snapshot)snapshotsApi.Show(snapshotId);

            Assert.IsTrue(request.Description.Equals(result.Description));
        }

        [TestMethod]
        public void RollBackSnapshot()
        {
            snapshotsApi.RollbackSnapshot(new RollbackSnapshotRequest { StorageId = storageId, SnapshotId = snapshotId });
        }

        [TestMethod]
        public void DeleteSnapshot()
        {
            snapshotsApi.Delete(snapshotId);
        }

        #endregion

    }
}

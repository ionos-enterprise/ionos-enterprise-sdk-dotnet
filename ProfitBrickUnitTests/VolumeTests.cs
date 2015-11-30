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
    public class VolumeTests
    {
        #region Volumes
        Volumes volumesApi = ProfitBricksSoapClient.Instance().Volumes;
        private static string volumeId = string.Empty;
        private static string dcId = string.Empty;
        private static string serverId;

        [ClassInitialize()]
        public static void Initialize(TestContext testContext)
        {
            var dcs = ProfitBricksSoapClient.Instance().DataCenters.Get();

            Assert.IsNotNull(dcs, "At least one DC is require to test Storages");
            dcId = dcs.FirstOrDefault().DataCenterId;

            serverId = dcs.FirstOrDefault().Servers.Where(s => s.ProvisioningState == ProvisioningState.AVAILABLE).FirstOrDefault().ServerId;
        }

        [TestMethod]
        public void CreateVolume()
        {
            var request = new CreateVolumeRequest
            {
                DataCenterId = dcId,
                Size = 1
            };

            var response = volumesApi.Create(request);

            Assert.IsNotNull(response);

            volumeId = response.Id;
        }

        [TestMethod]
        public void GetAllVolumes()
        {
            var volumes = volumesApi.Get();

            Assert.IsNotNull(volumes);
        }

        [TestMethod]
        public void GetOneVolume()
        {
            Assert.IsNotNull(volumesApi.Show(volumeId));
        }

        [TestMethod]
        public void UpdateVolume()
        {
            var request = new UpdateStorageRequest { StorageId = volumeId, StorageName = "new name" };

            volumesApi.Update(request);

            var volume = volumesApi.Show(volumeId);

            Assert.AreEqual(request.StorageName, volume.StorageName);
        }

        [TestMethod]
        public void ConnectVolume()
        {
            volumesApi.ConnectVolume(new ConnectStorageRequest { ServerId = serverId, BusType = BusType.IDE, StorageId = volumeId });
        }

        [TestMethod]
        public void DisconnectVolume()
        {
            volumesApi.DisconnectVolume(volumeId, serverId);
        }

        [TestMethod]
        public void DeleteVolume()
        {
            volumesApi.Delete(volumeId);
        }

        #endregion
    }
}

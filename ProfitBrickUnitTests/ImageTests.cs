using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProfitBricks.Client;
using ProfitBricks.Client.Resources;
using ProfitBricks.POCO.Enums;
using ProfitBricks.POCO.Requests;
using System.Linq;

namespace ProfitBrickUnitTests
{
    [TestClass]
    public class ImageTests
    {
        Images imagesApi = ProfitBricksSoapClient.Instance().Images;
        private static string dcId;
        private static string imageId;
        private static string serverId;

        #region Images

        [ClassInitialize]
        public static void Initialize(TestContext testContext)
        {
            var dcs = ProfitBricksSoapClient.Instance().DataCenters.Get();

            Assert.IsNotNull(dcs, "At least one Datacenter is required to run server tests");

            var dc = dcs.Where(d => d.DataCenterName == "test").FirstOrDefault();
            dcId = dc.DataCenterId;

            var servers = dc.Servers;

            Assert.IsNotNull(servers, "At least one Server is required to run server tests");

            serverId = servers.FirstOrDefault().ServerId;
        }

        [TestMethod]
        public void CreateImage()
        {
            var request = new CreateVolumeRequest
            {
                DataCenterId = dcId,
                Size = 1,
                StorageName = "jg test"
            };

            var response = imagesApi.Create(request);

            Assert.IsNotNull(response);

            imageId = response.Id;
        }

        [TestMethod]
        public void GetAllImages()
        {
            var images = imagesApi.Get();
            var temp = images.Where(i => i.Location == Location.uslas).FirstOrDefault();
            Assert.IsNotNull(images);
        }

        [TestMethod]
        public void GetOneImage()
        {
            var image = imagesApi.Show(imageId);

            Assert.IsNotNull(image);
        }

        [TestMethod]
        public void UpdateImage()
        {
            var request = new UpdateImageRequest
            {
                ImageId = imageId,
                ImageName = "test new name"
            };

            imagesApi.Update(request);

            var image = imagesApi.Show(imageId);

            Assert.AreEqual(request.ImageName, image.ImageName);
        }


        [TestMethod]
        public void ConnectImage()
        {
            var request = new ConnectStorageRequest
            {
                ServerId = serverId,
                StorageId = imageId,
                BusType = BusType.IDE
            };
            imagesApi.Connect(request);
        }

        [TestMethod]
        public void DisconnectImage()
        {
            imagesApi.Disconnect(imageId, serverId);
        }

        [TestMethod]
        public void DeleteImage()
        {
            imagesApi.Delete(imageId);
        }

        #endregion

    }
}

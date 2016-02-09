using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client;
using Api;
using System.Linq;

namespace ProfitbricksV2.Tests
{
    [TestClass]
    public class ImageApiTest
    {
        Configuration configuration;
        ImageApi imageApi;
        static string imageId;

        private void Configure()
        {
            configuration = new Configuration
            {
                Username = "muhamed@stackpointcloud.com",
                Password = "test123!",

            };
            imageApi = new ImageApi(configuration);
        }

        [TestMethod]
        public void ImagesList()
        {
            Configure();
            var list = imageApi.FindAll(depth: 5);

            Assert.IsTrue(list.Items.Count > 0);

            imageId = list.Items.FirstOrDefault().Id;

        }

        [TestMethod]
        public void ImageGet()
        {
            Configure();
            var img = imageApi.FindById(imageId);

            Assert.AreEqual(imageId, img.Id);
        }

    }
}

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
        ImageApi imageApi = new ImageApi(Config.Configuration);
        static string imageId;
        
        [TestInitialize]
        public void ImagesListImages()
        {
            var list = imageApi.FindAll(depth: 5);

            Assert.IsTrue(list.Items.Count > 0);

            imageId = list.Items.FirstOrDefault().Id;

            ImagesGetImage();
        }

        [TestMethod]
        public void ImagesGetImage()
        {
            var img = imageApi.FindById(imageId);

            Assert.AreEqual(imageId, img.Id);
        }

    }
}

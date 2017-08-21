using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client;
using Api;
using System.Linq;

namespace ProfitBricksSDK.Tests
{
    [TestClass]
    public class ImageApiTest
    {
        ImageApi imageApi = new ImageApi(Config.Configuration);
        static string imageId;
        static string instanceType = "image";

        [TestMethod]
        public void ImageList()
        {
            var list = imageApi.FindAll(depth: 5);

            Assert.IsTrue(list.Items.Count > 0);
            Assert.AreEqual(instanceType, list.Items[0].Type);

            imageId = list.Items.FirstOrDefault().Id;
        }

        [TestMethod]
        public void ImageGet()
        {
            var img = imageApi.FindById(imageId);

            Assert.AreEqual(imageId, img.Id);
            Assert.AreEqual(instanceType, img.Type);
            Assert.IsFalse(string.IsNullOrEmpty(img.Properties.Name));
            Assert.IsTrue(string.IsNullOrEmpty(img.Properties.Description));
            Assert.IsTrue(img.Properties.Size > 0);
            Assert.IsNotNull(img.Properties.CpuHotPlug);
            Assert.IsNotNull(img.Properties.CpuHotUnplug);
            Assert.IsNotNull(img.Properties.DiscScsiHotPlug);
            Assert.IsNotNull(img.Properties.DiscScsiHotUnplug);
            Assert.IsNotNull(img.Properties.DiscVirtioHotPlug);
            Assert.IsNotNull(img.Properties.DiscVirtioHotUnplug);
            Assert.IsNotNull(img.Properties.NicHotPlug);
            Assert.IsNotNull(img.Properties.NicHotUnplug);
            Assert.IsNotNull(img.Properties.RamHotPlug);
            Assert.IsNotNull(img.Properties.RamHotUnplug);
            Assert.IsNotNull(img.Properties.Public);
            Assert.IsTrue(Config.Locations.Contains(img.Properties.Location));
            Assert.IsTrue(Config.LicenseTypes.Contains(img.Properties.LicenceType));
            Assert.IsTrue(Config.ImageTypes.Contains(img.Properties.ImageType));
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void ImageGetFail()
        {
            try
            {
                imageApi.FindById("00000000-0000-0000-0000-000000000000");
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(Config.NotFoundError));
                throw;
            }
        }
    }
}

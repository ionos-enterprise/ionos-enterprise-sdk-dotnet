using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProfitBricks.Client;
using System.Linq;

namespace ProfitBrickUnitTests
{
    [TestClass]
    public class DriveTests
    {
        private static string imageId;
        private static string serverId;

        #region RomDrives

        [ClassInitialize()]
        public static void Initialize(TestContext testContext)
        {
            var servers = ProfitBricksSoapClient.Instance().Servers.Get();
            Assert.IsNotNull(servers, "At least one Server is required for Drive testing.");

            serverId = servers.FirstOrDefault().ServerId;

            var images = ProfitBricksSoapClient.Instance().Images.Get();
            Assert.IsNotNull(images, "At least one Image is required for Drive testing.");

            imageId = images.Where(i=> i.Location == ProfitBricks.POCO.Enums.Location.uslasdev).FirstOrDefault().ImageId;
        }

        [TestMethod]
        public void AddRomToserver()
        {
            ProfitBricksSoapClient.Instance().Drives.AddRomDrive(imageId, serverId, 0);
        }

        [TestMethod]
        public void RemoveRomFromserver()
        {
            ProfitBricksSoapClient.Instance().Drives.RemoveRomDrive(imageId, serverId);
        }

        #endregion
    }
}

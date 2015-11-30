using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProfitBricks.Client;
using ProfitBricks.Client.Resources;
using ProfitBricks.POCO.Requests;
using System.Linq;

namespace ProfitBrickUnitTests
{
    [TestClass]
    public class PublicIpBlockTests
    {
        PublicIpBlocks publicIpBlocksApi = ProfitBricksSoapClient.Instance().PublicIpBlocks;
        private static string blockId;
        private static string nicId;
        
        [ClassInitialize]
        public static void Initialize(TestContext testContext)
        {
            var nics = ProfitBricksSoapClient.Instance().Nics.Get();

            Assert.IsNotNull(nics, "At least one NIC is required to run IP block tests");

            nicId = nics.FirstOrDefault().NicId;
        }

        [TestMethod]
        public void GetAllPublicIpBlocks()
        {
            var ips = publicIpBlocksApi.Get();

            Assert.IsNotNull(ips);
        }

        [TestMethod]
        public void GetOnePublicIpBlocks()
        {
            var ips = publicIpBlocksApi.Show(blockId);

            Assert.IsNotNull(ips);
        }

        [TestMethod]
        public void CreateReservePublicIpBlock()
        {
            var request = new CreateReservePublicIpBlockRequest
            {
                BlockSize = 12,
                Location = ProfitBricks.POCO.Enums.Location.uslas
            };
            var response = publicIpBlocksApi.Create(request);

            Assert.IsNotNull(response);

            blockId = response.Id;
        }

        [TestMethod]
        public void AddPublicIpToNic()
        {
            var ip = "184.106.164.212";

            publicIpBlocksApi.AddPublicIpToNic(ip, nicId);
        }

        [TestMethod]
        public void RemovePublicIpFromNic()
        {
            var ip = "10.0.0.0";

            publicIpBlocksApi.RemovePublicIpFromNic(ip, nicId);
        }

        [TestMethod]
        public void RelesePublicIpBlock()
        {
            publicIpBlocksApi.ReleasePublicIpBlock(blockId);
        }
    }
}

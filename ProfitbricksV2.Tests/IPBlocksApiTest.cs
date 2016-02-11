using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client;
using Api;
using Model;
using System.Threading;

namespace ProfitbricksV2.Tests
{
    [TestClass]
    public class IPBlocksApiTest
    {
        Configuration configuration;
        IPBlocksApi ipApi;
        static IpBlock ipBlock;

        private void Configure()
        {
            configuration = new Configuration
            {
                Username = "test@stackpointcloud.com",
                Password = "pwd",

            };
            ipApi = new IPBlocksApi(configuration);
        }

        [TestMethod]
        public void IPCreate()
        {
            Configure();
            ipBlock = new IpBlock { Properties = new IpBlockProperties { Location = "us/lasdev", Size = 1 } };
            ipBlock = ipApi.Create(ipBlock);
            DoWait(ipBlock.Request);
            Assert.IsNotNull(ipBlock);
        }

        [TestMethod]
        public void IPGet()
        {
            Configure();
            var newIp = ipApi.FindById(ipBlock.Id, depth: 5);
            Assert.AreEqual(ipBlock.Id, newIp.Id);
        }

        [TestMethod]
        public void IPList()
        {
            Configure();
            var list = ipApi.FindAll(depth: 5);
            Assert.IsTrue(list.Items.Count > 0);
        }

        [TestMethod]
        public void IPDelete()
        {
            Configure();
            var resp = ipApi.Delete(ipBlock.Id);
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
            } while (request.Metadata.Status != "DONE" && counter != 35);
        }

    }
}

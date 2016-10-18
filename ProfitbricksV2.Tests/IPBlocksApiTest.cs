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
        IPBlocksApi ipApi = new IPBlocksApi(Config.Configuration);
        static IpBlock ipBlock;

        [TestInitialize]
        public void IPCreate()
        {
            ipBlock = new IpBlock { Properties = new IpBlockProperties { Location = "us/las", Size = 1 } };
            ipBlock = ipApi.Create(ipBlock);
            Config.DoWait(ipBlock.Request);
            Assert.IsNotNull(ipBlock);
        }

        [TestMethod]
        public void IPGet()
        {
            var newIp = ipApi.FindById(ipBlock.Id, depth: 5);
            Assert.AreEqual(ipBlock.Id, newIp.Id);
        }

        [TestMethod]
        public void IPList()
        {
            var list = ipApi.FindAll(depth: 5);
            Assert.IsTrue(list.Items.Count > 0);
        }

        [TestCleanup]
        public void IPDelete()
        {
            var resp = ipApi.Delete(ipBlock.Id);
            Assert.IsNull(resp);
        }

    }
}
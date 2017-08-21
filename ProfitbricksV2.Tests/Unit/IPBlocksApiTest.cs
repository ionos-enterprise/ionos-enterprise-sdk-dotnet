using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client;
using Api;
using Model;
using System.Threading;

namespace ProfitBricksSDK.Tests
{
    [TestClass]
    public class IPBlocksApiTest
    {
        IPBlocksApi ipApi = new IPBlocksApi(Config.Configuration);
        static IpBlock ipBlock;
        static string instanceType = "ipblock";

        [TestMethod]
        public void IPCreate()
        {
            ipBlock = new IpBlock
            {
                Properties = new IpBlockProperties
                {
                    Name = Config.DefaultName,
                    Location = Config.DefaultLocation,
                    Size = 2
                }
            };
            ipBlock = ipApi.Create(ipBlock, depth: 5);
            Config.DoWait(ipBlock.Request);
            Assert.IsNotNull(ipBlock);

            Assert.AreEqual(instanceType, ipBlock.Type);
            Assert.AreEqual(Config.DefaultName, ipBlock.Properties.Name);
            Assert.AreEqual(Config.DefaultLocation, ipBlock.Properties.Location);
            Assert.AreEqual(2, ipBlock.Properties.Size);
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void IPCreateFail()
        {
            try
            {
                var req = new IpBlock
                {
                    Properties = new IpBlockProperties
                    {
                        Name = Config.DefaultName,
                        Size = 1
                    }
                };
                ipApi.Create(req);
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(string.Format(Config.MissingAttributeError, "location")));
                throw;
            }
        }

        [TestMethod]
        public void IPGet()
        {
            var newIp = ipApi.FindById(ipBlock.Id, depth: 5);
            Assert.AreEqual(ipBlock.Id, newIp.Id);
            Assert.AreEqual(ipBlock.Type, newIp.Type);
            Assert.AreEqual(ipBlock.Properties.Name, newIp.Properties.Name);
            Assert.AreEqual(ipBlock.Properties.Location, newIp.Properties.Location);
            Assert.AreEqual(ipBlock.Properties.Size, newIp.Properties.Size);
            Assert.AreEqual(ipBlock.Properties.Size, newIp.Properties.Ips.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void IPGetFail()
        {
            try
            {
                ipApi.FindById("00000000-0000-0000-0000-000000000000");
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(Config.NotFoundError));
                throw;
            }
        }

        [TestMethod]
        public void IPList()
        {
            var list = ipApi.FindAll(depth: 5);
            Assert.IsTrue(list.Items.Count > 0);
            Assert.AreEqual(instanceType, list.Items[0].Type);
        }

        [TestMethod]
        public void IPDelete()
        {
            var resp = ipApi.Delete(ipBlock.Id);
            Assert.IsNull(resp);
        }

    }
}
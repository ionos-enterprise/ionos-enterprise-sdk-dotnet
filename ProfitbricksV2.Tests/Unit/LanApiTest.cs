using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using Client;
using Api;
using Model;
using System.Collections.Generic;

namespace ProfitBricksSDK.Tests
{
    [TestClass]
    public class LanApiTest
    {
        DataCenterApi dcApi = new DataCenterApi(Config.Configuration);
        LanApi lanApi = new LanApi(Config.Configuration);
        static Datacenter datacenter;
        static Lan lan;
        static string instanceType = "lan";

        [TestMethod]
        public void LanCreate()
        {
            datacenter = TestHelper.CreateDatacenter();

            Assert.IsNotNull(datacenter);

            lan = lanApi.Create(datacenter.Id, new Lan
            {
                Properties = new LanProperties
                {
                    Public = true,
                    Name = Config.DefaultName
                }
            });

            Config.DoWait(lan.Request);
            Assert.IsNotNull(lan);

            Assert.AreEqual(instanceType, lan.Type);
            Assert.AreEqual(Config.DefaultName, lan.Properties.Name);
            Assert.AreEqual(true, lan.Properties.Public);
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void LanCreateFail()
        {
            try
            {
                lanApi.Create("00000000-0000-0000-0000-000000000000", new Lan());
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(Config.NotFoundError));
                throw;
            }
        }

        [TestMethod]
        public void LanGet()
        {
            var newLan = lanApi.FindById(datacenter.Id, lan.Id, depth: 1);
            Assert.AreEqual(lan.Id, newLan.Id);
            Assert.AreEqual(lan.Type, newLan.Type);
            Assert.AreEqual(lan.Properties.Name, newLan.Properties.Name);
            Assert.AreEqual(lan.Properties.Public, newLan.Properties.Public);
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void LanGetFail()
        {
            try
            {
                lanApi.FindById(datacenter.Id, "00000000-0000-0000-0000-000000000000");
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(Config.NotFoundError));
                throw;
            }
        }

        [TestMethod]
        public void LanList()
        {
            var list = lanApi.FindAll(datacenter.Id, depth: 1);
            Assert.IsTrue(list.Items.Count > 0);
            Assert.AreEqual(instanceType, list.Items[0].Type);
        }

        [TestMethod]
        public void LanUpdate()
        {
            var req = new LanProperties
            {
                Name = Config.DefaultName + " - RENAME",
                Public = false
            };
            var updated = lanApi.PartialUpdate(datacenter.Id, lan.Id, req);

            Assert.AreEqual(lan.Id, updated.Id);
            Assert.AreEqual(lan.Type, updated.Type);
            Assert.AreEqual(Config.DefaultName + " - RENAME", updated.Properties.Name);
            Assert.AreEqual(false, updated.Properties.Public);
        }

        [TestMethod]
        public void LanDelete()
        {
            var resp = lanApi.Delete(datacenter.Id, lan.Id);
            Assert.IsNull(resp);

            // cleanup
            resp = dcApi.Delete(datacenter.Id);
            Assert.IsNull(resp);
        }
    }
}

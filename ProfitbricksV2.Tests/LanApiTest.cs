using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using Client;
using Api;
using Model;

namespace ProfitbricksV2.Tests
{
    [TestClass]
    public class LanApiTest
    {
        DataCenterApi dcApi = new DataCenterApi(Config.Configuration);
        LanApi lanApi = new LanApi(Config.Configuration);
        static Datacenter datacenter;
        static Lan lan;


        [TestInitialize]
        public void LanCreate()
        {
            datacenter = new Datacenter
            {
                Properties = new DatacenterProperties
                {
                    Name = ".Net V2 - LAN Test " + DateTime.Now.ToShortTimeString(),
                    Description = "Unit test for .Net SDK PB REST V2",
                    Location = "us/las"
                },
                Entities = new DatacenterEntities
                {
                    Lans = new Lans
                    {
                        Items = new System.Collections.Generic.List<Lan>
                            {
                                new Lan
                                {
                                     Properties = new LanProperties {
                                         Public = true,
                                         Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString()
                                         }
                                }
                            }
                    }
                }
            };

            datacenter = dcApi.Create(datacenter, depth: 5);
            Assert.IsNotNull(datacenter);
            Config.DoWait(datacenter.Request);

            lan = datacenter.Entities.Lans.Items[0];
            Assert.IsNotNull(lan);
        }

        [TestMethod]
        public void LanGet()
        {
            var newLan = lanApi.FindById(datacenter.Id, lan.Id, depth: 5);
            Assert.AreEqual(lan.Id, newLan.Id);
        }

        [TestMethod]
        public void LanList()
        {
            var list = lanApi.FindAll(datacenter.Id, depth: 5);
            Assert.IsTrue(list.Items.Count > 0);
        }

        [TestMethod]
        public void LanUpdate()
        {
            var updated = lanApi.PartialUpdate(datacenter.Id, lan.Id, new LanProperties { Public = !lan.Properties.Public });
            Assert.AreEqual(!lan.Properties.Public, updated.Properties.Public);
        }

        [TestCleanup]
        public void LanDelete()
        {
            var resp = lanApi.Delete(datacenter.Id, lan.Id);
            resp = dcApi.Delete(datacenter.Id);
        }
    }
}

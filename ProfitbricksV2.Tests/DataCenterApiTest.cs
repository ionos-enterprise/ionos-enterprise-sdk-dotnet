using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using Api;
using Client;
using Model;
using System.Collections.Generic;
using System.Threading;

namespace ProfitbricksV2.Tests
{
    [TestClass]
    public class DataCenterTest
    {
        DataCenterApi dcApi = new DataCenterApi(Config.Configuration);
        static  Datacenter datacenter;

        [TestInitialize]
        public void DataCenterCreate()
        {
            datacenter = new Datacenter
            {
                Properties = new DatacenterProperties
                {
                    Name = ".Net V2 - DC Test " + DateTime.Now.ToShortTimeString(),
                    Description = "Unit test for .Net SDK PB REST V2",
                    Location = "us/las"
                },
                Entities = new DatacenterEntities
                {
                    Servers = new Servers
                    {
                        Items = new List<Server>
                        {
                            new Server
                            {
                                Properties = new ServerProperties
                                {
                                    Cores = 1,
                                    Ram = 1024,
                             
                                }
                            }
                        }
                    }
                }
            };

            datacenter = dcApi.Create(datacenter);
            Config.DoWait(datacenter.Request);
            Assert.IsNotNull(datacenter);
        }

        [TestMethod]
        public void DataCenterGet()
        {
            var dc = dcApi.FindById(datacenter.Id, depth: 5);

            Assert.AreEqual(datacenter.Id, dc.Id);
        }

        [TestMethod]
        public void DataCenterList()
        {
            var list = dcApi.FindAll(depth: 5);

            Assert.IsTrue(list.Items.Count > 0);
        }


        [TestMethod]
        public void DataCenterUpdate()
        {
            var resp = dcApi.PartialUpdate(datacenter.Id, new DatacenterProperties { Name = datacenter.Properties.Name + " - updated" });

            Assert.AreNotEqual(datacenter.Properties.Name, resp.Properties.Name);
        }

        [TestCleanup]
        public void DataCenterDelete()
        {
            var resp = dcApi.Delete(datacenter.Id);
        }
    }
}

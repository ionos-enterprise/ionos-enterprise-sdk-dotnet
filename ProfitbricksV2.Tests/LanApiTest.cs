using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using Client;
using Api;
using Model;
using System.Collections.Generic;

namespace ProfitbricksV2.Tests
{
    [TestClass]
    public class LanApiTest
    {
        DataCenterApi dcApi = new DataCenterApi(Config.Configuration);
        NetworkInterfacesApi nicApi = new NetworkInterfacesApi(Config.Configuration);
        ServerApi serverApi = new ServerApi(Config.Configuration);
        LanApi lanApi = new LanApi(Config.Configuration);
        static Datacenter datacenter;
        static Lan lan;
        static Nic nic;
        static Server server;


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




            datacenter = dcApi.Create(datacenter, depth: 5);
            Assert.IsNotNull(datacenter);
            Config.DoWait(datacenter.Request);
            server = datacenter.Entities.Servers.Items[0];
            //create nic to associate it later on with the lan
            nic = new Nic { Properties = new NicProperties { Lan = 1, Nat = false } };
            nic = nicApi.Create(datacenter.Id, server.Id, nic);
            Config.DoWait(nic.Request);
            // this was added because the DoWait is not enough and the lan would fail to create
            Thread.Sleep(15000);
            //creating a lan and associating an nic to it
            lan = lanApi.Create(datacenter.Id, new Lan
            {
                Properties = new LanProperties
                {
                    Public = true,
                    Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString()
                },
                Entities=new LanEntities{
                    Nics= new LanNics
                    {
                        Items= new List<Nic>()
                        {
                            new Nic
                            {
                                Id=nic.Id
                            }
                        }

                    }

                }
            });
            Config.DoWait(lan.Request);
            Assert.IsNotNull(lan);
            Assert.IsNotNull(lan.Entities.Nics);
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
           dcApi.Delete(datacenter.Id);
        }
    }
}

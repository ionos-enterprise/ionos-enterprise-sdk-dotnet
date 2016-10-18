using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client;
using Api;
using Model;
using System.Threading;

namespace ProfitbricksV2.Tests
{
    [TestClass]
    public class NicApiTest
    {
        DataCenterApi dcApi = new DataCenterApi(Config.Configuration);
        ServerApi serverApi = new ServerApi(Config.Configuration);
        NetworkInterfacesApi nicApi = new NetworkInterfacesApi(Config.Configuration);
        LoadBalancerApi lbApi = new LoadBalancerApi(Config.Configuration);
        static Datacenter datacenter;
        static Server server;
        static Nic nic;
        static Loadbalancer lb;

        [TestInitialize]
        public void NicCreate()
        {
            //Create a datacenter.

            datacenter = new Datacenter
            {
                Properties = new DatacenterProperties
                {
                    Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString(),
                    Description = "Unit test for .Net SDK PB REST V2",
                    Location = "us/las"
                },
                Entities = new DatacenterEntities
                {
                    Servers = new Servers
                    {
                        Items = new System.Collections.Generic.List<Server>
                            {
                                new Server
                        {
                                    Properties = new ServerProperties
                                    {
                                        Name = ".Net V2 - NIC Test " + DateTime.Now.ToShortTimeString(),
                                        Cores = 1,
                                        Ram = 256,
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
            lb = lbApi.Create(datacenter.Id, new Loadbalancer
            {
                Properties = new LoadbalancerProperties { Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString() }
            }, depth: 5);
            Config.DoWait(lb.Request);
            
            nic = new Nic { Properties = new NicProperties { Lan = 1, Nat = false } };

            nic = nicApi.Create(datacenter.Id, server.Id, nic);

            Config.DoWait(nic.Request);

            Assert.IsNotNull(nic);
        }

        [TestMethod]
        public void NicGet()
        {
            var newNic = nicApi.FindById(datacenter.Id, server.Id, nic.Id);

            Assert.AreEqual(nic.Id, newNic.Id);
            Assert.IsFalse((bool)nic.Properties.Nat);
        }

        [TestMethod]
        public void NicList()
        {
            var list = nicApi.FindAll(datacenter.Id, server.Id);

            Assert.IsTrue(list.Items.Count > 0);
        }

        [TestMethod]
        public void NicUpdate()
        {
            var updated = nicApi.PartialUpdate(datacenter.Id, server.Id, nic.Id, new NicProperties { Name = nic.Properties.Name + " -Update", Ips = new System.Collections.Generic.List<string> { "10.8.52.225", "1.1.1.1" } });

            Assert.AreEqual(nic.Properties.Name + " -Update", updated.Properties.Name);
        }

        [TestMethod]
        public void NicAttach()
        {
            var attachedNic = nicApi.AttachNic(datacenter.Id, lb.Id, new Nic { Id = nic.Id });
            Config.DoWait(attachedNic.Request);

            Assert.IsNotNull(attachedNic);
        }

        [TestMethod]
        public void BalancedNicList()
        {
            var balancedNics = lbApi.FindAll(datacenter.Id, lb.Id, 5);

            var balancedNic = lbApi.FindById(datacenter.Id, lb.Id, nic.Id, 5);

            Assert.AreEqual(nic.Id, balancedNic.Id);
            var resp = nicApi.DetachNic(datacenter.Id, lb.Id, nic.Id);

            Config.DoWait(resp);

            balancedNics = lbApi.FindAll(datacenter.Id, lb.Id, 5);
        }

        [TestCleanup]
        public void NicDelete()
        {
            var resp = nicApi.Delete(datacenter.Id, server.Id, nic.Id);

            resp = dcApi.Delete(datacenter.Id);
            Assert.IsNull(resp);
        }
    }
}

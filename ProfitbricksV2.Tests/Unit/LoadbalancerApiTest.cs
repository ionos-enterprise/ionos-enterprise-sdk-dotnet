using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Api;
using Client;
using Model;
using System.Collections.Generic;

namespace ProfitBricksSDK.Tests
{
    [TestClass]
    public class LoadbalancerApiTest
    {
        IDataCenterApi dcApi = new DataCenterApi(Config.Configuration);
        ILoadBalancerApi lbApi = new LoadBalancerApi(Config.Configuration);
        INetworkInterfacesApi nicApi = new NetworkInterfacesApi(Config.Configuration);
        ILanApi lanApi = new LanApi(Config.Configuration);
        static Datacenter datacenter;
        static Lan lan;
        static Server server1;
        static Server server2;
        static Nic nic;
        static Nic lbNic;
        static Loadbalancer lb;
        static string instanceType = "loadbalancer";

        [TestMethod]
        public void LoadBalancerCreate()
        {
            datacenter = new Datacenter
            {
                Properties = new DatacenterProperties
                {
                    Name = Config.DefaultName,
                    Location = Config.DefaultLocation
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
                                    Name = Config.DefaultName,
                                    Cores = 1,
                                    Ram = 1024,
                                }
                            },
                            new Server
                            {
                                Properties = new ServerProperties
                                {
                                    Name = Config.DefaultName,
                                    Cores = 1,
                                    Ram = 1024,
                                }
                            }
                        }
                    },
                    Lans = new Lans
                    {
                        Items = new List<Lan>
                        {
                            new Lan
                            {
                                Properties = new LanProperties
                                {
                                    Name = Config.DefaultName,
                                    Public = false
                                }
                            }
                        }
                    }
                }
            };

            datacenter = dcApi.Create(datacenter, depth: 5);
            Assert.IsNotNull(datacenter);
            Config.DoWait(datacenter.Request);

            server1 = datacenter.Entities.Servers.Items[0];
            server2 = datacenter.Entities.Servers.Items[1];
            lan = datacenter.Entities.Lans.Items[0];

            nic = new Nic
            {
                Properties = new NicProperties
                {
                    Name = Config.DefaultName,
                    Lan = int.Parse(lan.Id),
                    Dhcp = true,
                    Nat = false,
                    FirewallActive = true
                }
            };

            nic = nicApi.Create(datacenter.Id, server1.Id, nic);
            Assert.IsNotNull(nic);
            Config.DoWait(nic.Request);

            lb = new Loadbalancer
            {
                Properties = new LoadbalancerProperties
                {
                    Name = Config.DefaultName,
                    Dhcp = true
                },
                Entities = new LoadbalancerEntities
                {
                    Balancednics = new BalancedNics
                    {
                        Items = new List<Nic>
                        {
                            new Nic
                            {
                                Id = nic.Id
                            }
                        }
                    }
                }
            };

            lb = lbApi.Create(datacenter.Id, lb, depth: 5);
            Assert.IsNotNull(lb);
            Config.DoWait(lb.Request);

            Assert.AreEqual(instanceType, lb.Type);
            Assert.AreEqual(Config.DefaultName, lb.Properties.Name);
            Assert.IsTrue(nic.Properties.Dhcp.Value);
            Assert.IsNotNull(lb.Entities.Balancednics);
            //Thread.Sleep(60000);
        }

        [TestMethod]
        public void LoadbalancerGet()
        {
            var newLb = lbApi.FindById(datacenter.Id, lb.Id);

            Assert.AreEqual(lb.Id, newLb.Id);
            Assert.AreEqual(lb.Type, newLb.Type);
            Assert.AreEqual(lb.Properties.Name, newLb.Properties.Name);
            Assert.IsTrue(newLb.Properties.Dhcp.Value);
            Assert.IsFalse(string.IsNullOrEmpty(newLb.Properties.Ip));
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void LoadbalancerGetFail()
        {
            try
            {
                lbApi.FindById(datacenter.Id, "00000000-0000-0000-0000-000000000000");
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(Config.NotFoundError));
                throw;
            }
        }

        [TestMethod]
        public void LoadbalancerList()
        {
            var list = lbApi.FindAll(datacenter.Id);

            Assert.IsTrue(list.Items.Count > 0);
            Assert.AreEqual(instanceType, list.Items[0].Type);
        }

        [TestMethod]
        public void LoadbalancerNicList()
        {
            BalancedNics list = lbApi.FindAll(datacenter.Id, lb.Id);

            Assert.IsTrue(list.Items.Count > 0);
            Assert.AreEqual("nic", list.Items[0].Type);
        }

        [TestMethod]
        public void LoadbalancerNicGet()
        {
            var resp = lbApi.FindById(datacenter.Id, lb.Id, nic.Id);

            Assert.AreEqual(nic.Id, resp.Id);
            Assert.AreEqual(nic.Type, resp.Type);
            Assert.AreEqual(nic.Properties.Name, resp.Properties.Name);
            Assert.AreEqual(nic.Properties.Dhcp, resp.Properties.Dhcp);
            Assert.AreEqual(1, resp.Properties.Lan);
            Assert.IsTrue(resp.Properties.FirewallActive.Value);
            Assert.IsFalse(resp.Properties.Nat.Value);
            Assert.IsTrue(resp.Properties.Ips.Count > 0);
            Assert.IsTrue(Config.MacRegex.IsMatch(resp.Properties.Mac));
        }

        [TestMethod]
        public void LoadbalancerNicAttach()
        {
            lbNic = new Nic
            {
                Properties = new NicProperties
                {
                    Name = Config.DefaultName,
                    Lan = int.Parse(lan.Id),
                    Dhcp = true,
                    Ips = new List<string> { "192.168.11.11" },
                    Nat = false,
                    FirewallActive = true
                }
            };

            lbNic = nicApi.Create(datacenter.Id, server2.Id, lbNic);
            Assert.IsNotNull(lbNic);
            Config.DoWait(lbNic.Request);

            var resp = nicApi.AttachNic(datacenter.Id, lb.Id, new Nic { Id = lbNic.Id });
            Assert.IsNotNull(resp);
            Config.DoWait(resp.Request);

            Assert.AreEqual(lbNic.Id, resp.Id);
            Assert.AreEqual(lbNic.Properties.Name, resp.Properties.Name);
        }

        [TestMethod]
        public void LoadbalancerNicDetach()
        {
            var resp = nicApi.DetachNic(datacenter.Id, lb.Id, lbNic.Id);
            Assert.IsNull(resp);
        }

        [TestMethod]
        public void LoadbalancerUpdate()
        {
            var newLb = lbApi.PartialUpdate(datacenter.Id, lb.Id, new LoadbalancerProperties { Name = lb.Properties.Name + " - RENAME" });

            Assert.AreEqual(newLb.Properties.Name, lb.Properties.Name + " - RENAME");
        }

        [TestMethod]
        public void LoadbalancerDelete()
        {
            var resp = lbApi.Delete(datacenter.Id, lb.Id);
            Assert.IsNull(resp);
            resp = dcApi.Delete(datacenter.Id);
        }
    }
}

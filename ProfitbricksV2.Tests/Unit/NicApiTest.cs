using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client;
using Api;
using Model;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace ProfitBricksSDK.Tests
{
    [TestClass]
    public class NicApiTest
    {
        DataCenterApi dcApi = new DataCenterApi(Config.Configuration);
        ServerApi serverApi = new ServerApi(Config.Configuration);
        NetworkInterfacesApi nicApi = new NetworkInterfacesApi(Config.Configuration);
        LoadBalancerApi lbApi = new LoadBalancerApi(Config.Configuration);
        static Datacenter datacenter;
        static Lan lan;
        static Server server;
        static Nic nic;
        static string instanceType = "nic";

        [TestMethod]
        public void NicCreate()
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
                    Servers = TestHelper.BuildServers(),
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

            server = datacenter.Entities.Servers.Items[0];
            lan = datacenter.Entities.Lans.Items[0];
            var ips = new List<string> { "10.0.0.1" };

            nic = new Nic
            {
                Properties = new NicProperties
                {
                    Name = Config.DefaultName,
                    Lan = int.Parse(lan.Id),
                    Dhcp = true,
                    FirewallActive = true,
                    Nat = false,
                    Ips = ips
                }
            };

            nic = nicApi.Create(datacenter.Id, server.Id, nic);
            Assert.IsNotNull(nic);
            Config.DoWait(nic.Request);

            Assert.AreEqual(instanceType, nic.Type);
            Assert.AreEqual(Config.DefaultName, nic.Properties.Name);
            Assert.IsFalse(nic.Properties.Nat.Value);
            Assert.IsTrue(nic.Properties.Dhcp.Value);
            Assert.IsTrue(nic.Properties.FirewallActive.Value);
            Assert.AreEqual(lan.Id, nic.Properties.Lan.ToString());
            Assert.IsTrue(nic.Properties.Ips.Count > 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void NicCreateFail()
        {
            try
            {
                var req = new Nic
                {
                    Properties = new NicProperties
                    {
                        Name = Config.DefaultName
                    }
                };
                nicApi.Create(datacenter.Id, server.Id, req);
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(string.Format(Config.MissingAttributeError, "lan")));
                throw;
            }
        }

        [TestMethod]
        public void NicGet()
        {
            var newNic = nicApi.FindById(datacenter.Id, server.Id, nic.Id);

            Assert.AreEqual(nic.Id, newNic.Id);
            Assert.AreEqual(nic.Type, newNic.Type);
            Assert.AreEqual(nic.Properties.Name, newNic.Properties.Name);
            Assert.IsFalse(newNic.Properties.Nat.Value);
            Assert.IsTrue(newNic.Properties.Dhcp.Value);
            Assert.IsTrue(newNic.Properties.FirewallActive.Value);
            Assert.AreEqual(nic.Properties.Lan, newNic.Properties.Lan);
            Assert.IsTrue(newNic.Properties.Ips.Count > 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void NicGetFail()
        {
            try
            {
                nicApi.FindById(datacenter.Id, server.Id, "00000000-0000-0000-0000-000000000000");
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(Config.NotFoundError));
                throw;
            }
        }

        [TestMethod]
        public void NicList()
        {
            var list = nicApi.FindAll(datacenter.Id, server.Id);

            Assert.IsTrue(list.Items.Count > 0);
            Assert.AreEqual(instanceType, list.Items[0].Type);
        }

        [TestMethod]
        public void NicUpdate()
        {
            var updated = nicApi.PartialUpdate(datacenter.Id, server.Id, nic.Id, new NicProperties { Name = nic.Properties.Name + " - RENAME" });

            Assert.AreEqual(nic.Properties.Name + " - RENAME", updated.Properties.Name);
        }

        [TestMethod]
        public void NicDelete()
        {
            var resp = nicApi.Delete(datacenter.Id, server.Id, nic.Id);
            Assert.IsNull(resp);

            resp = dcApi.Delete(datacenter.Id);
            Assert.IsNull(resp);
        }
    }
}

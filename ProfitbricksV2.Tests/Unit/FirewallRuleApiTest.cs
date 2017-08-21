using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client;
using Api;
using Model;
using System.Threading;
using System.Collections.Generic;

namespace ProfitBricksSDK.Tests
{
    [TestClass]
    public class FirewallRuleApiTest
    {
        IDataCenterApi dcApi = new DataCenterApi(Config.Configuration);
        IServerApi serverApi = new ServerApi(Config.Configuration);
        INetworkInterfacesApi nicApi = new NetworkInterfacesApi(Config.Configuration);
        ILoadBalancerApi lbApi = new LoadBalancerApi(Config.Configuration);
        IFirewallRuleApi fwApi = new FirewallRuleApi(Config.Configuration);

        static Datacenter datacenter;
        static Server server;
        static Lan lan;
        static Nic nic;
        static FirewallRule fw;
        static string instanceType = "firewall-rule";

        [TestMethod]
        public void FirewallRuleCreate()
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

            nic = new Nic { Properties = new NicProperties { Lan = int.Parse(lan.Id) } };
            nic = nicApi.Create(datacenter.Id, server.Id, nic);
            Config.DoWait(nic.Request);


            fw = new FirewallRule
            {
                Properties = new FirewallruleProperties
                {
                    Protocol = "TCP",
                    Name = "SSH",
                    PortRangeStart = 22,
                    PortRangeEnd = 22,
                    SourceMac = "01:23:45:67:89:00"
                }
            };

            fw = fwApi.Create(datacenter.Id, server.Id, nic.Id, fw);

            Config.DoWait(fw.Request);
            Assert.IsNotNull(fw);
            Assert.AreEqual(instanceType, fw.Type);
            Assert.AreEqual("SSH", fw.Properties.Name);
            Assert.AreEqual("TCP", fw.Properties.Protocol);
            Assert.AreEqual("01:23:45:67:89:00", fw.Properties.SourceMac);
            Assert.AreEqual(22, fw.Properties.PortRangeStart);
            Assert.AreEqual(22, fw.Properties.PortRangeEnd);
            Assert.IsNull(fw.Properties.SourceIp);
            Assert.IsNull(fw.Properties.TargetIp);
            Assert.IsNull(fw.Properties.IcmpCode);
            Assert.IsNull(fw.Properties.IcmpType);
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void FirewallRuleCreateFail()
        {
            try
            {
                var req = new FirewallRule
                {
                    Properties = new FirewallruleProperties
                    {
                        Name = "SSH"
                    }
                };
                fwApi.Create(datacenter.Id, server.Id, nic.Id, req);
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(string.Format(Config.MissingAttributeError, "protocol")));
                throw;
            }
        }

        [TestMethod]
        public void FirewallRuleGet()
        {
            var newFw = fwApi.FindById(datacenter.Id, server.Id, nic.Id, fw.Id);

            Assert.AreEqual(fw.Id, newFw.Id);
            Assert.AreEqual(fw.Type, newFw.Type);
            Assert.AreEqual(fw.Properties.Name, newFw.Properties.Name);
            Assert.AreEqual(fw.Properties.Protocol, newFw.Properties.Protocol);
            Assert.AreEqual(fw.Properties.SourceMac, newFw.Properties.SourceMac);
            Assert.AreEqual(fw.Properties.PortRangeStart, newFw.Properties.PortRangeStart);
            Assert.AreEqual(fw.Properties.PortRangeEnd, newFw.Properties.PortRangeEnd);
            Assert.IsNull(newFw.Properties.SourceIp);
            Assert.IsNull(newFw.Properties.TargetIp);
            Assert.IsNull(newFw.Properties.IcmpCode);
            Assert.IsNull(newFw.Properties.IcmpType);
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void FirewallRuleGetFail()
        {
            try
            {
                fwApi.FindById(datacenter.Id, server.Id, nic.Id, "00000000-0000-0000-0000-000000000000");
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(Config.NotFoundError));
                throw;
            }
        }

        [TestMethod]
        public void FirewallRuleUpdate()
        {
            var updated = fwApi.PartialUpdate(datacenter.Id, server.Id, nic.Id, fw.Id, new FirewallruleProperties {Name = fw.Properties.Name + " - RENAME" });

            Assert.AreEqual(fw.Id, updated.Id);
            Assert.AreEqual(fw.Type, updated.Type);
            Assert.AreEqual(fw.Properties.Name + " - RENAME", updated.Properties.Name);
        }

        [TestMethod]
        public void FirewallRuleList()
        {
            var list = fwApi.FindAll(datacenter.Id, server.Id, nic.Id, depth: 5);

            Assert.IsTrue(list.Items.Count > 0);
            Assert.AreEqual(instanceType, list.Items[0].Type);
        }

        [TestMethod]
        public void FirewallRuleDelete()
        {
            var resp = fwApi.Delete(datacenter.Id, server.Id, nic.Id, fw.Id);

            Assert.IsNull(resp);

            resp = dcApi.Delete(datacenter.Id);

            Assert.IsNull(resp);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client;
using Api;
using Model;
using System.Threading;

namespace ProfitbricksV2.Tests
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
        static Nic nic;
        static FirewallRule fw;

        [TestInitialize]
        public void Configure()
        {
            //Create a datacenter.
            if (datacenter == null)
            {
                datacenter = new Datacenter
                {
                    Properties = new DatacenterProperties
                    {
                        Name = ".Net V2 - FW Test " + DateTime.Now.ToShortTimeString(),
                        Description = "Unit test for .Net SDK PB REST V2",
                        Location = "us/lasdev"
                    }
                };

                datacenter = dcApi.Create(datacenter);
            }

            if (server == null)
            {
                server = new Server
                {
                    Properties = new ServerProperties
                    {
                        Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString(),
                        Cores = 1,
                        Ram = 256
                    }
                };

                server = serverApi.Create(datacenter.Id, server);
                Config.DoWait(server.Request);
            }

            if (nic == null)
            {
                nic = new Nic { Properties = new NicProperties { Lan = 1 } };

                nic = nicApi.Create(datacenter.Id, server.Id, nic);

               Config.DoWait(nic.Request);
            }
            
        
            fw = new FirewallRule { Properties = new FirewallruleProperties { Protocol = "TCP", Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString(), } };

            fw = fwApi.Create(datacenter.Id, server.Id, nic.Id, fw);

            Config.DoWait(fw.Request);

            Assert.IsNotNull(fw);
        }

        [TestMethod]
        public void FirewallGet()
        {
            Configure();
            var newFw = fwApi.FindById(datacenter.Id, server.Id, nic.Id, fw.Id);

            Assert.AreEqual(fw.Id, newFw.Id);
        }

        [TestMethod]
        public void FirewallUpdate()
        {
            Configure();
            var updated = fwApi.PartialUpdate(datacenter.Id, server.Id, nic.Id, fw.Id, new FirewallruleProperties {Name = fw.Properties.Name + " -Updated" });

            Assert.AreEqual(fw.Properties.Name + " -Updated", updated.Properties.Name);
        }

        [TestMethod]
        public void FirewallList()
        {
            Configure();
            var list = fwApi.FindAll(datacenter.Id, server.Id, nic.Id, depth: 5);

            Assert.IsTrue(list.Items.Count > 0);
        }

        [TestCleanup]
        public void FirewallDelete()
        {
            Configure();
            var resp = fwApi.Delete(datacenter.Id, server.Id, nic.Id, fw.Id);

            Assert.IsNull(resp);

            resp = dcApi.Delete(datacenter.Id);

            Assert.IsNull(resp);

        }
    }
}

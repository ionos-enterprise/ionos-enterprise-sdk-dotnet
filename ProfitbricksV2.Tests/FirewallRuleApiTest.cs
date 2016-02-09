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
        Configuration configuration;
        IDataCenterApi dcApi;
        IServerApi serverApi;
        INetworkInterfacesApi nicApi;
        ILoadBalancerApi lbApi;
        IFirewallRuleApi fwApi;

        static Datacenter datacenter;
        static Server server;
        static Nic nic;
        static FirewallRule fw;

        public Configuration Configuration
        {
            get
            {
                return configuration;
            }

            set
            {
                configuration = value;
            }
        }

        private void Configure()
        {
            Configuration = new Configuration
            {
                Username = "muhamed@stackpointcloud.com",
                Password = "test123!",

            };

            dcApi = new DataCenterApi(configuration);
            serverApi = new ServerApi(configuration);
            nicApi = new NetworkInterfacesApi(configuration);
            lbApi = new LoadBalancerApi(configuration);
            fwApi = new FirewallRuleApi(configuration);

            //Create a datacenter.
            if (datacenter == null)
            {
                datacenter = new Datacenter
                {
                    Properties = new DatacenterProperties
                    {
                        Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString(),
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
                DoWait(server.Request);
            }

            if (nic == null)
            {
                nic = new Nic { Properties = new NicProperties { Lan = 1 } };

                nic = nicApi.Create(datacenter.Id, server.Id, nic);

                DoWait(nic.Request);
            }

            bool isBusy = true;
            while (isBusy == true)
            {
                var temp = dcApi.FindById(datacenter.Id);
                if (temp.Metadata.State != "BUSY") isBusy = false;
                Thread.Sleep(5000);
            }
        }

        [TestMethod]
        public void FirewallCreate()
        {
            Configure();
            fw = new FirewallRule { Properties = new FirewallruleProperties { Protocol = "TCP", Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString(), } };

            fw = fwApi.Create(datacenter.Id, server.Id, nic.Id, fw);

            DoWait(fw.Request);

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

        [TestMethod]
        public void FirewallDelete()
        {
            Configure();
            var resp = fwApi.Delete(datacenter.Id, server.Id, nic.Id, fw.Id);

            Assert.IsNull(resp);

            resp = dcApi.Delete(datacenter.Id);

            Assert.IsNull(resp);

        }

        private void DoWait(string requestUrl)
        {
            if (string.IsNullOrEmpty(requestUrl))
                return;
            var requestApi = new RequestApi(configuration);

            var sub = requestUrl.Substring(requestUrl.IndexOf("requests/") + 9, 36);
            var request = new RequestStatus();
            int counter = 0;

            do
            {
                request = requestApi.GetStatus(sub);
                counter++;
                Thread.Sleep(1000);
                if (counter == 35)
                    break;
                else if (request.Metadata.Status == "FAILED")
                    throw new Exception(request.Metadata.Message);
            } while (request.Metadata.Status != "DONE" && counter != 35);
        }
    }
}

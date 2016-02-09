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
        Configuration configuration;
        IDataCenterApi dcApi;
        IServerApi serverApi;
        INetworkInterfacesApi nicApi;
        ILoadBalancerApi lbApi;
        static Datacenter datacenter;
        static Server server;
        static Nic nic;
        static Loadbalancer lb;

        private void Configure()
        {
            configuration = new Configuration
            {
                Username = "muhamed@stackpointcloud.com",
                Password = "test123!",

            };

            dcApi = new DataCenterApi(configuration);
            serverApi = new ServerApi(configuration);
            nicApi = new NetworkInterfacesApi(configuration);
            lbApi = new LoadBalancerApi(configuration);

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

            if(server == null)
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

            if (lb == null)
            {
                lb = new Loadbalancer
                {
                    Properties = new LoadbalancerProperties { Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString() }
                };

                lb = lbApi.Create(datacenter.Id, lb);

                DoWait(lb.Request);
            }
        }

        [TestMethod]
        public void NicCreate() {
            Configure();
            nic = new Nic { Properties = new NicProperties { Lan = 1 } };

            nic = nicApi.Create(datacenter.Id, server.Id, nic);

            DoWait(nic.Request);


            bool isBusy = true;

            while (isBusy == true)
            {
                var temp = dcApi.FindById(datacenter.Id);
                if (temp.Metadata.State != "BUSY") isBusy = false;
                Thread.Sleep(1500);
            }


            Assert.IsNotNull(nic);
        }

        [TestMethod]
        public void NicGet()
        {
            Configure();
            var newNic = nicApi.FindById(datacenter.Id, server.Id, nic.Id);

            Assert.AreEqual(nic.Id, newNic.Id);
        }

        [TestMethod]
        public void NicList()
        {
            Configure();
            var list = nicApi.FindAll(datacenter.Id, server.Id);

            Assert.IsTrue(list.Items.Count > 0);
        }

        [TestMethod]
        public void NicUpdate()
        {
            Configure();
            var updated = nicApi.PartialUpdate(datacenter.Id, server.Id, nic.Id, new NicProperties { Name = nic.Properties.Name + " -Update" });

            Assert.AreEqual(nic.Properties.Name + " -Update", updated.Properties.Name);
        }

        [TestMethod]
        public void NicAssociate()
        {
            Configure();
          //  lbApi.

        }


        [TestMethod]
        public void NicDelete()
        {
            Configure();
            var resp = nicApi.Delete(datacenter.Id, server.Id, nic.Id);

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
            } while (request.Metadata.Status != "DONE" && counter != 35);
        }

    }
}

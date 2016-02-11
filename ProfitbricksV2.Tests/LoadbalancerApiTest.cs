using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Api;
using Client;
using Model;
using System.Threading;

namespace ProfitbricksV2.Tests
{
    [TestClass]
    public class LoadbalancerApiTest
    {
        Configuration configuration;
        IDataCenterApi dcApi;
        ILoadBalancerApi lbApi;
        static Datacenter datacenter;
        static Loadbalancer lb;

        private void Configure()
        {
            configuration = new Configuration
            {
                Username = "test@stackpointcloud.com",
                Password = "pwd",

            };

            dcApi = new DataCenterApi(configuration);
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
        }

        [TestMethod]
        public void LoadbalancerCreate()
        {
            Configure();
            lb = new Loadbalancer
            {
                Properties = new LoadbalancerProperties { Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString() }
            };

            lb = lbApi.Create(datacenter.Id, lb);

            DoWait(lb.Request);

            Assert.IsNotNull(lb);
        }
        
        [TestMethod]
        public void LoadbalancerGet()
        {
            Configure();
            var newLb = lbApi.FindById(datacenter.Id, lb.Id);

            Assert.AreEqual(lb.Id, newLb.Id);
        }

        [TestMethod]
        public void LoadbalancerList()
        {
            Configure();
            var list = lbApi.FindAll(datacenter.Id);

            Assert.IsTrue(list.Items.Count > 0);
        }

        [TestMethod]
        public void LoadbalancerUpdate()
        {
            Configure();
            var newLb = lbApi.PartialUpdate(datacenter.Id, lb.Id, new LoadbalancerProperties { Name = lb.Properties.Name + " -Updated" });

            Assert.AreEqual(newLb.Properties.Name, lb.Properties.Name + " -Updated");
        }

        [TestMethod]
        public void LoadbalancerDelete()
        {
            Configure();
            var resp = lbApi.Delete(datacenter.Id, lb.Id);
            resp = dcApi.Delete(datacenter.Id);
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

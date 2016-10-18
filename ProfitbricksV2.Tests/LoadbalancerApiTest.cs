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
        IDataCenterApi dcApi = new DataCenterApi(Config.Configuration);
        ILoadBalancerApi lbApi = new LoadBalancerApi(Config.Configuration);
        static Datacenter datacenter;
        static Loadbalancer lb;

        [TestInitialize]
        public void LoadBalancerCreate()
        {
            //Create a datacenter.
            if (datacenter == null)
            {
                datacenter = new Datacenter
                {
                    Properties = new DatacenterProperties
                    {
                        Name = ".Net V2 - LB Test " + DateTime.Now.ToShortTimeString(),
                        Description = "Unit test for .Net SDK PB REST V2",
                        Location = "us/las"
                    }
                };

                datacenter = dcApi.Create(datacenter);
                Assert.IsNotNull(datacenter);

                Config.DoWait(datacenter.Request);
                lb = new Loadbalancer
                {
                    Properties = new LoadbalancerProperties
                    {
                        Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString()
                    }
                };

                lb = lbApi.Create(datacenter.Id, lb, depth: 5);
                Assert.IsNotNull(lb);
                Config.DoWait(lb.Request);
            }
        }

        [TestMethod]
        public void LoadbalancerGet()
        {
            var newLb = lbApi.FindById(datacenter.Id, lb.Id);

            Assert.AreEqual(lb.Id, newLb.Id);
        }

        [TestMethod]
        public void LoadbalancerList()
        {
            var list = lbApi.FindAll(datacenter.Id);

            Assert.IsTrue(list.Items.Count > 0);
        }

        [TestMethod]
        public void LoadbalancerUpdate()
        {
            var newLb = lbApi.PartialUpdate(datacenter.Id, lb.Id, new LoadbalancerProperties { Name = lb.Properties.Name + " -Updated" });

            Assert.AreEqual(newLb.Properties.Name, lb.Properties.Name + " -Updated");
        }

        [TestCleanup]
        public void LoadbalancerDelete()
        {
            var resp = lbApi.Delete(datacenter.Id, lb.Id);
            resp = dcApi.Delete(datacenter.Id);
        }

    }
}

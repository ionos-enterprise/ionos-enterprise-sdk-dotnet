using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProfitBricks.Client;
using ProfitBricks.Client.Resources;
using ProfitBricks.POCO.Requests;
using System.Collections.Generic;
using System.Linq;

namespace ProfitBrickUnitTests
{
    [TestClass]
    public class LoadBalancerTests
    {
        LoadBalancers loadBalancersApi = ProfitBricksSoapClient.Instance.LoadBalancers;
        private static string serverId;
        private static string storageId;
        private static string dcId;
        private static string loadbalancerId;

        #region Load Balancers

        [ClassInitialize()]
        public static void Initialize(TestContext testContext)
        {
            var dcs = ProfitBricksSoapClient.Instance.DataCenters.Get();

            Assert.IsNotNull(dcs, "At least one DC is require to test Storages");
            dcId = dcs.FirstOrDefault().DataCenterId;

            var volumes = ProfitBricksSoapClient.Instance.Volumes.Get();

            Assert.IsNotNull(volumes, "At least one volume is require to test Storages");
            storageId = volumes.FirstOrDefault().StorageId;


            var servers = ProfitBricksSoapClient.Instance.Servers.Get();

            Assert.IsNotNull(volumes, "At least one server is require to test Storages");
            serverId = servers.Where(s => s.ProvisioningState == ProfitBricks.POCO.Enums.ProvisioningState.AVAILABLE).FirstOrDefault().ServerId;
        }

        [TestMethod]
        public void CreateLoadBalancer()
        {
            var request = new CreateLbRequest();
            request.DataCenterId = dcId;
            request.LoadBalancerName = "test lb";
            request.LoadBalancerAlgorithm = ProfitBricks.POCO.Enums.LoadBalancerAlgorithm.ROUND_ROBIN;

            //request.ServerIds = new List<string> { serverId };

            var response = loadBalancersApi.Create(request);
            Assert.IsNotNull(response);

            loadbalancerId = response.Id;
        }

        [TestMethod]
        public void GetAllLoadBalancers()
        {
            var lbs = loadBalancersApi.Get();
            Assert.IsNotNull(lbs);
        }

        [TestMethod]
        public void GetOneLoadBalancer()
        {
            var lb = loadBalancersApi.Show(loadbalancerId);

            Assert.IsNotNull(lb);
        }

        [TestMethod]
        public void RegisterLoadBalancer()
        {
            loadBalancersApi.RegisterServer(loadbalancerId, new List<string> { serverId });
        }

        [TestMethod]
        public void DeregisterLoadBalancer()
        {
            loadBalancersApi.UnregisterServer(loadbalancerId, new List<string> { serverId });
        }

        [TestMethod]
        public void UpdateLoadBalancer()
        {
            var request = new UpdateLoadBalancerRequest
            {
                LoadBalancerId = loadbalancerId,
                LoadBalancerName = "test name"
            };

            loadBalancersApi.Update(request);

            var lb = loadBalancersApi.Show(loadbalancerId);

            Assert.AreEqual(request.LoadBalancerName, lb.LoadBalancerName);
        }

        [TestMethod]
        public void DeleteLoadBalancer()
        {
            loadBalancersApi.Delete(loadbalancerId);
        }
        #endregion
    }
}

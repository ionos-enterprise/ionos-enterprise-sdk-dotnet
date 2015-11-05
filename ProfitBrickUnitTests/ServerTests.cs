using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProfitBricks.POCO.Requests;
using ProfitBricks.Client.Resources;
using ProfitBricks.Client;
using ProfitBricks.POCO.Responses;
using System.Diagnostics;
using System.Linq;
using ProfitBricks.POCO;

namespace ProfitBrickUnitTests
{
    [TestClass]
    public class ServerTests
    {
        Servers serverApi = ProfitBricksSoapClient.Instance().Servers;
        private static string serverId = string.Empty;
        private static string dcId = string.Empty;

        #region Server

        [ClassInitialize()]
        public static void Initialize(TestContext testContext)
        {
            var dcs = ProfitBricksSoapClient.Instance().DataCenters.Get();

            Assert.IsNotNull(dcs, "At least one Datacenter is required to run server tests");

            dcId = dcs.FirstOrDefault().DataCenterId;
        }
        
        [TestMethod]
        public void CreateServer()
        {
            var request = new CreateServerRequest();
            request.DataCenterId = dcId;
            request.AvailabilityZone = ProfitBricks.POCO.Enums.AvailabilityZone.AUTO;
            request.Cores = 4;
            request.InternetAccess = true;
            request.OsType = ProfitBricks.POCO.Enums.OsType.WINDOWS;
            request.Ram = 256;

            var response = (CreateServerResponse)serverApi.Create(request);

            serverId = response.Id;

            Assert.IsNotNull(serverApi.Show(serverId));
        }

        [TestMethod]
        public void GetAllServers()
        {
            var servers = serverApi.Get();

            Assert.IsNotNull(servers);
            Assert.IsTrue(servers.Count != 0);
        }

        [TestMethod]
        public void UpdateServer()
        {
            var request = new UpdateServerRequest { ServerId = serverId, ServerName = "newName", Cores = 3, Ram = 512 };

            serverApi.Update(request);

            var server = serverApi.Show(request.ServerId);

            Assert.AreEqual(request.ServerName, server.ServerName);

        }

        [TestMethod]
        public void GetOneServer()
        {
            var server = serverApi.Show(serverId);

            Assert.IsNotNull(server);
        }

        [TestMethod]
        public void ResetServer()
        {
            serverApi.ResetServer(serverId);
        }

        [TestMethod]
        public void StartServer()
        {
            serverApi.StartServer(serverId);
        }

        [TestMethod]
        public void StopServer()
        {
            serverApi.StopServer(serverId);
        }

        [TestMethod]
        public void DeleteServer()
        {
            serverApi.Delete(serverId);
        }

        #endregion

    }
}

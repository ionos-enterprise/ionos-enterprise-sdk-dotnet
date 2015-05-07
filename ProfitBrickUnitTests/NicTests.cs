using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProfitBricks.Client;
using ProfitBricks.Client.Resources;
using ProfitBricks.POCO;
using ProfitBricks.POCO.Enums;
using ProfitBricks.POCO.Requests;
using ProfitBricks.POCO.Responses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProfitBrickUnitTests
{
    [TestClass]
    public class NicTests
    {
        Nics nicApi = ProfitBricksSoapClient.Instance.Nics;
        private static string nicId;
        private static string dcId;
        private static string serverId;

        #region Nics

        [ClassInitialize]
        public static void Initialize(TestContext testContext)
        {
            var dcs = ProfitBricksSoapClient.Instance.DataCenters.Get();

            Assert.IsNotNull(dcs, "At least one Datacenter is required to run server tests");

            var dc = dcs.Where(d => d.DataCenterName == "test").FirstOrDefault();

            dcId = dc.DataCenterId;

            var servers = dc.Servers;

            Assert.IsNotNull(servers, "At least one Server is required to run server tests");

            var server = servers.FirstOrDefault();

            if(server.Nics.Count>5)
            {
                ProfitBricksSoapClient.Instance.Nics.Delete(server.Nics[5].NicId);
            }
            serverId = server.ServerId;
        }

        [TestMethod]
        public void CreateNic()
        {
            var request = new CreateNicRequest();

            request.ServerId = serverId;
            request.NicName = "testing 1234 nics";
            request.DhcpActive = false;

            var response = nicApi.Create(request);

            Nic nic = nicApi.Show(response.Id);

            Assert.AreEqual(request.NicName, nic.NicName);
            nicId = response.Id;
        }

        [TestMethod]
        public void GetAllNics()
        {
            var allNics = nicApi.Get();

            Assert.IsNotNull(allNics);
        }

        [TestMethod]
        public void GetOneNic()
        {
            var nic = nicApi.Show(nicId);

            Assert.IsNotNull(nic);
        }

        [TestMethod]
        public void UpdateNic()
        {
            nicApi.Update(new UpdateNicRequest { NicId = nicId, NicName = "whatever", DhcpActive = false });

            Assert.AreEqual("whatever", nicApi.Show(nicId).NicName);
        }

        [TestMethod]
        public void SetInternetAccess()
        {
            nicApi.SetInternetAccess(dcId, 0, true);
        }

        [TestMethod]
        public void DeleteNic()
        {
            nicApi.Delete(nicId);
        }

        #endregion

    }
}

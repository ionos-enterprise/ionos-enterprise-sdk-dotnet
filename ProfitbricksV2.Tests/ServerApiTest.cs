using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client;
using Model;
using Api;

namespace ProfitbricksV2.Tests
{
    [TestClass]
    public class ServerApiTest
    {
        Configuration configuration;
        DataCenterApi dcApi;
        ServerApi serverApi;
        static Datacenter datacenter;
        static Server server;


        private void Configure()
        {
            configuration = new Configuration
            {
                Username = "muhamed@stackpointcloud.com",
                Password = "test123!",

            };

            dcApi = new DataCenterApi(configuration);

            serverApi = new ServerApi(configuration);

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
        public void CreateServer()
        {
            Configure();

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

            Assert.IsNotNull(server);
        }

        [TestMethod]
        public void GetServer()
        {
            Configure();


            DoWait(server.Request);

            var oldServer = serverApi.FindById(datacenter.Id, server.Id);

            Assert.AreEqual(oldServer.Id, server.Id);
            Assert.AreEqual(oldServer.Properties.Name, server.Properties.Name);
        }

        [TestMethod]
        public void PatchServer()
        {
            Configure();

            DoWait(server.Request);
            var updated = serverApi.PartialUpdate(datacenter.Id, server.Id, new ServerProperties { Name = server.Properties.Name + " -Updated" });

            Assert.AreEqual(updated.Properties.Name, server.Properties.Name + " -Updated");
        }


        [TestMethod]
        public void ListServers()
        {
            Configure();

            var list = serverApi.FindAll(datacenter.Id);

            Assert.IsTrue(list.Items.Count > 0);
        }

        [TestMethod]
        public void StartServer()
        {
            Configure();

           var error = serverApi.Start(datacenter.Id, server.Id);
            Assert.IsNull(error);
            var stoppedServer = serverApi.FindById(datacenter.Id, server.Id);
            
            Assert.IsTrue(stoppedServer.Properties.VmState != "RUNNING");
        }

        [TestMethod]
        public void DeleteServer()
        {
            Configure();
            var response = serverApi.Delete(datacenter.Id, server.Id);
            response = dcApi.Delete(datacenter.Id);
            Assert.IsNull(response);
        }

        private void DoWait(string requestUrl)
        {
            var requestApi = new RequestApi(configuration);

            var sub = server.Request.Substring(requestUrl.IndexOf("requests/") + 9, 36);
            var request = new RequestStatus();


            do
            {
                request = requestApi.GetStatus(sub);
            } while (request.Metadata.Status != "DONE");
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client;
using Model;
using Api;
using System.Threading;

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
        public void ServerCreate()
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
        public void ServerGet()
        {
            Configure();
            DoWait(server.Request);

            var oldServer = serverApi.FindById(datacenter.Id, server.Id);

            Assert.AreEqual(oldServer.Id, server.Id);
            Assert.AreEqual(oldServer.Properties.Name, server.Properties.Name);
        }

        [TestMethod]
        public void ServerUpdate()
        {
            Configure();
            DoWait(server.Request);

            var updated = serverApi.PartialUpdate(datacenter.Id, server.Id, new ServerProperties { Name = server.Properties.Name + " -Updated" });

            Assert.AreEqual(updated.Properties.Name, server.Properties.Name + " -Updated");
        }

        [TestMethod]
        public void ServerList()
        {
            Configure();

            var list = serverApi.FindAll(datacenter.Id);

            Assert.IsTrue(list.Items.Count > 0);
        }

        [TestMethod]
        public void ServerStop()
        {
            Configure();

            var error = serverApi.Stop(datacenter.Id, server.Id);
            Assert.IsNull(error);
            Thread.Sleep(20000);

            var counter = 0;
            Server stoppedServer;

            do {
                stoppedServer = serverApi.FindById(datacenter.Id, server.Id);
                Thread.Sleep(1);
            }while(counter == 15);

            Assert.AreEqual("SHUTOFF", stoppedServer.Properties.VmState);
        }

        [TestMethod]
        public void ServerStart()
        {
            Configure();

            var error = serverApi.Start(datacenter.Id, server.Id);
            Assert.IsNull(error);
            Thread.Sleep(20000);

            var counter = 0;
            Server runningServer;

            do
            {
                runningServer = serverApi.FindById(datacenter.Id, server.Id);
                Thread.Sleep(1);
            } while (counter == 15);

            Assert.AreEqual("RUNNING", runningServer.Properties.VmState);
        }

        [TestMethod]

        public void ServerReboot()
        {
            Configure();

            var resp = serverApi.Reboot(datacenter.Id, server.Id);

            Assert.IsNull(resp);
        }

        [TestMethod]
        public void ServerDelete()
        {
            Configure();
            var response = serverApi.Delete(datacenter.Id, server.Id);
            response = dcApi.Delete(datacenter.Id);

            Assert.IsNull(response);
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

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client;
using Model;
using Api;
using System.Threading;
using System.Collections.Generic;

namespace ProfitbricksV2.Tests
{
    [TestClass]
    public class ServerApiTest
    {
        DataCenterApi dcApi = new DataCenterApi(Config.Configuration);
        ServerApi serverApi = new ServerApi(Config.Configuration);
        ImageApi imageApi = new ImageApi(Config.Configuration);
        AttachedCDROMsApi attachCDROMApi = new AttachedCDROMsApi(Config.Configuration);
        static Datacenter datacenter;
        static Server server;
        static Image cDROMImage;

        [TestInitialize]
        public void ServerCreate()
        {

            datacenter = new Datacenter
            {
                Properties = new DatacenterProperties
                {
                    Name = ".Net V2 - Server Test " + DateTime.Now.ToShortTimeString(),
                    Description = "Unit test for .Net SDK PB REST V2",
                    Location = "us/las"
                },
                Entities = new DatacenterEntities
                {
                    Servers = new Servers
                    {
                        Items = new List<Server>
                        {
                            new Server
                            {
                                Properties = new ServerProperties
                                {
                                    Name = "Test Server",
                                    Cores = 1,
                                    Ram = 1024,
                                }
                            }
                        }
                    }
                }
            };

            datacenter = dcApi.Create(datacenter, depth: 5);
            Config.DoWait(datacenter.Request);
            Assert.IsNotNull(datacenter);

            cDROMImage = imageApi.FindAll(depth: 5).Items.Find(i => i.Properties.LicenceType == "LINUX"
            && i.Properties.ImageType == "CDROM"
            && i.Metadata.State == "AVAILABLE"
            && i.Properties.Public == true);

            server = datacenter.Entities.Servers.Items[0];

            Assert.IsNotNull(server);
        }

        [TestMethod]
        public void ServerGet()
        {
            var oldServer = serverApi.FindById(datacenter.Id, server.Id);

            Assert.AreEqual(oldServer.Id, server.Id);
            Assert.AreEqual(oldServer.Properties.Name, server.Properties.Name);
        }

        [TestMethod]
        public void ServerUpdate()
        {
            var updated = serverApi.PartialUpdate(datacenter.Id, server.Id, new ServerProperties { Name = server.Properties.Name + " -Updated" });

            Assert.AreEqual(updated.Properties.Name, server.Properties.Name + " -Updated");
        }

        [TestMethod]
        public void ServerList()
        {
            var list = serverApi.FindAll(datacenter.Id);

            Assert.IsTrue(list.Items.Count > 0);
        }

        [TestMethod]
        public void ServerStop()
        {
            var error = serverApi.Stop(datacenter.Id, server.Id);
            Assert.IsNull(error);
            Thread.Sleep(20000);

            var stoppedServer = serverApi.FindById(datacenter.Id, server.Id);

            Assert.AreEqual("SHUTOFF", stoppedServer.Properties.VmState);
        }

        [TestMethod]
        public void ServerStart()
        {
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
            var resp = serverApi.Reboot(datacenter.Id, server.Id);

            Assert.IsNull(resp);
        }


        [TestMethod]

        public void AttachListGetCDROM()
        {
            var attached = attachCDROMApi.Attach(datacenter.Id, server.Id, new Image { Id=cDROMImage.Id});
            Assert.AreEqual(attached.Id, cDROMImage.Id);
            Config.DoWait(attached.Request);

            var listAttached = attachCDROMApi.FindAll(datacenter.Id, server.Id);
            Assert.IsTrue(listAttached.Items.Count > 0);

            var getAttached = attachCDROMApi.FindById(datacenter.Id, server.Id, listAttached.Items[0].Id);
            Assert.AreEqual(listAttached.Items[0].Id, getAttached.Id);

        }



        [TestCleanup]
        public void ServerDelete()
        {
            var response = serverApi.Delete(datacenter.Id, server.Id);
            Assert.IsNull(response);

            response = dcApi.Delete(datacenter.Id);

            Assert.IsNull(response);
        }
    }
}

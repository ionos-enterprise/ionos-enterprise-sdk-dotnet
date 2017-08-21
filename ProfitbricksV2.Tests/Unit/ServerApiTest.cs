using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client;
using Model;
using Api;
using System.Threading;
using System.Collections.Generic;

namespace ProfitBricksSDK.Tests
{
    [TestClass]
    public class ServerApiTest
    {
        DataCenterApi dcApi = new DataCenterApi(Config.Configuration);
        ServerApi serverApi = new ServerApi(Config.Configuration);
        AttachedCDROMsApi attachCDROMApi = new AttachedCDROMsApi(Config.Configuration);
        AttachedVolumesApi attachVolumesApi = new AttachedVolumesApi(Config.Configuration);
        VolumeApi volumeApi = new VolumeApi(Config.Configuration);
        static Datacenter datacenter;
        static Server server;
        static Image sourceCDROM;
        static Image attachedCDROM;
        static Image sourceImage;
        static Volume bootVolume;
        static Volume volume;
        static string instanceType = "server";

        [TestMethod]
        public void ServerCreate()
        {
            sourceImage = TestHelper.GetImage("Ubuntu-16", "HDD", Config.DefaultLocation);
            Assert.IsNotNull(sourceImage);

            var entities = new DatacenterEntities
            {
                Volumes = new Volumes
                {
                    Items = new List<Volume>
                    {
                        new Volume
                        {
                            Properties = new VolumeProperties
                            {
                                Name = Config.DefaultName,
                                Size = 2,
                                Bus = "VIRTIO",
                                Type = "HDD",
                                Image = sourceImage.Id,
                                SshKeys = new List<string> {  "ssh-rsa AAAAB3NzaC1" }
                            }
                        }
                    }
                }
            };

            datacenter = TestHelper.CreateDatacenter(entities: entities);
            Assert.IsNotNull(datacenter);

            bootVolume = volumeApi.FindAll(datacenter.Id, depth: 1).Items[0];
            Assert.IsNotNull(bootVolume);

            var req = new Server
            {
                Properties = new ServerProperties
                {
                    Name = Config.DefaultName,
                    Cores = 1,
                    Ram = 1024,
                    CpuFamily = "INTEL_XEON",
                    AvailabilityZone = "ZONE_1",
                    BootVolume = new ResourceReference
                    {
                        Id = bootVolume.Id
                    }
                }
            };

            server = serverApi.Create(datacenter.Id, req, depth: 5);
            Assert.IsNotNull(server);

            Assert.AreEqual(instanceType, server.Type);
            Assert.AreEqual(Config.DefaultName, server.Properties.Name);
            Assert.AreEqual(1024, server.Properties.Ram);
            Assert.AreEqual(1, server.Properties.Cores);
            Assert.AreEqual("ZONE_1", server.Properties.AvailabilityZone);
            Assert.AreEqual("INTEL_XEON", server.Properties.CpuFamily);
            Assert.AreEqual(bootVolume.Id, server.Properties.BootVolume.Id);
            Thread.Sleep(30000);
        }

        [TestMethod]
        public void ServerCreateComposite()
        {
            if (sourceImage == null)
            {
                sourceImage = TestHelper.GetImage("Ubuntu-16", "HDD", Config.DefaultLocation);
                Assert.IsNotNull(sourceImage);
            }

            if (datacenter == null)
                datacenter = TestHelper.CreateDatacenter();

            var lanApi = new LanApi(Config.Configuration);

            var lan = lanApi.Create(datacenter.Id, new Lan
            {
                Properties = new LanProperties
                {
                    Public = true,
                    Name = Config.DefaultName
                }
            });

            Config.DoWait(lan.Request);
            Assert.IsNotNull(lan);

            var comReq = new Server
            {
                Properties = new ServerProperties
                {
                    Name = ".NET SDK Test Composite",
                    Cores = 1,
                    Ram = 1024
                },
                Entities = new ServerEntities
                {
                    Nics = new Nics
                    {
                        Items = new List<Nic>
                        {
                           new Nic
                           {
                               Properties = new NicProperties
                               {
                                   Name = Config.DefaultName,
                                   Dhcp = true,
                                   FirewallActive = true,
                                   Nat = false,
                                   Lan = int.Parse(lan.Id)
                               },
                               Entities = new NicEntities
                               {
                                   Firewallrules = new FirewallRules
                                   {
                                       Items = new List<FirewallRule>
                                       {
                                           new FirewallRule
                                           {
                                               Properties = new FirewallruleProperties
                                               {
                                                   Name = "SSH",
                                                   Protocol = "TCP",
                                                   PortRangeStart = 22,
                                                   PortRangeEnd = 22,
                                                   SourceMac = "01:23:45:67:89:00"
                                               }
                                           }
                                       }
                                   }
                               }
                           }
                        }
                    },
                    Volumes = new AttachedVolumes
                    {
                        Items = new List<Volume>
                        {
                            new Volume
                            {
                                Properties = new VolumeProperties
                                {
                                    Name = Config.DefaultName,
                                    Size = 2,
                                    Bus = "VIRTIO",
                                    Type = "HDD",
                                    Image = sourceImage.Id,
                                    AvailabilityZone = "ZONE_3",
                                    SshKeys = new List<string> {  "ssh-rsa AAAAB3NzaC1" }
                                }
                            }
                        }
                    }
                }
            };

            var comSrv = serverApi.Create(datacenter.Id, comReq, depth: 5);
            Assert.IsNotNull(comSrv);

            Assert.AreEqual(instanceType, comSrv.Type);
            Assert.AreEqual(".NET SDK Test Composite", comSrv.Properties.Name);
            Assert.AreEqual(1024, comSrv.Properties.Ram);
            Assert.AreEqual(1, comSrv.Properties.Cores);
            Assert.IsTrue(comSrv.Entities.Nics.Items.Count > 0);
            Assert.IsTrue(comSrv.Entities.Volumes.Items.Count > 0);
            Thread.Sleep(60000);
        }

        [TestMethod]
        public void ServerGet()
        {
            var resp = serverApi.FindById(datacenter.Id, server.Id);

            Assert.AreEqual(server.Id, resp.Id);
            Assert.AreEqual(server.Properties.Name, resp.Properties.Name);
            Assert.AreEqual(server.Type, resp.Type);
            Assert.AreEqual(server.Properties.Ram, resp.Properties.Ram);
            Assert.AreEqual(server.Properties.Cores, resp.Properties.Cores);
            Assert.AreEqual(server.Properties.AvailabilityZone, resp.Properties.AvailabilityZone);
            Assert.AreEqual(server.Properties.CpuFamily, resp.Properties.CpuFamily);
            Assert.AreEqual(server.Properties.BootVolume.Id, resp.Properties.BootVolume.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void ServerGetFail()
        {
            try
            {
                serverApi.FindById(datacenter.Id, "00000000-0000-0000-0000-000000000000");
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(Config.NotFoundError));
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void ServerCreateFail()
        {
            try
            {
                var req = new Server
                {
                    Properties = new ServerProperties
                    {
                        Name = Config.DefaultName,
                        Ram = 1024,
                    }
                };
                serverApi.Create(datacenter.Id, req);
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(string.Format(Config.MissingAttributeError, "cores")));
                throw;
            }
        }

        [TestMethod]
        public void ServerUpdate()
        {
            var updated = serverApi.PartialUpdate(datacenter.Id, server.Id, new ServerProperties { Name = server.Properties.Name + " - RENAME" });

            Assert.AreEqual(server.Id, updated.Id);
            Assert.AreEqual(server.Properties.Name + " - RENAME", updated.Properties.Name);
        }

        [TestMethod]
        public void ServerList()
        {
            var list = serverApi.FindAll(datacenter.Id);

            Assert.IsTrue(list.Items.Count > 0);
            Assert.AreEqual(instanceType, list.Items[0].Type);
        }

        [TestMethod]
        public void ServerStop()
        {
            var error = serverApi.Stop(datacenter.Id, server.Id);
            Assert.IsNull(error);
            Thread.Sleep(20000);
        }

        [TestMethod]
        public void ServerStart()
        {
            var error = serverApi.Start(datacenter.Id, server.Id);
            Assert.IsNull(error);
            Thread.Sleep(20000);
        }

        [TestMethod]
        public void ServerReboot()
        {
            var resp = serverApi.Reboot(datacenter.Id, server.Id);
            Assert.IsNull(resp);
        }

        [TestMethod]
        public void ServerAttachVolume()
        {
            var req = new Volume
            {
                Properties = new VolumeProperties
                {
                    Name = Config.DefaultName,
                    Size = 2,
                    Bus = "VIRTIO",
                    Type = "HDD",
                    LicenceType = "UNKNOWN"
                }
            };

            volume = attachVolumesApi.AttachVolume(datacenter.Id, server.Id, req, depth: 5);
            Config.DoWait(volume.Request);
            Assert.IsNotNull(volume);

            server = serverApi.FindById(datacenter.Id, server.Id, depth: 5);

            Assert.AreEqual(req.Properties.Name, volume.Properties.Name);
            Assert.AreEqual(req.Properties.Size, volume.Properties.Size);
            Assert.AreEqual(req.Properties.Bus, volume.Properties.Bus);
            Assert.AreEqual(req.Properties.Type, volume.Properties.Type);
            Assert.AreEqual(req.Properties.LicenceType, volume.Properties.LicenceType);
            Assert.IsTrue(attachVolumesApi.FindAll(datacenter.Id, server.Id, depth: 5).Items.Exists(v => v.Id == volume.Id));
        }

        [TestMethod]
        public void ServerListAttachedVolumes()
        {
            var list = attachVolumesApi.FindAll(datacenter.Id, server.Id, depth: 5);

            Assert.IsTrue(list.Items.Count > 0);
            Assert.AreEqual("volume", list.Items[0].Type);
        }

        [TestMethod]
        public void ServerGetAttachedVolume()
        {
            var vol = attachVolumesApi.FindById(datacenter.Id, server.Id, volume.Id);

            Assert.AreEqual(volume.Id, vol.Id);
            Assert.AreEqual(volume.Type, vol.Type);
            Assert.AreEqual(volume.Properties.Name, vol.Properties.Name);
            Assert.AreEqual(volume.Properties.Size, vol.Properties.Size);
            Assert.AreEqual(volume.Properties.Bus, vol.Properties.Bus);
            Assert.AreEqual(volume.Properties.LicenceType, vol.Properties.LicenceType);
        }

        [TestMethod]
        public void ServerDetachVolume()
        {
            var resp = attachVolumesApi.DetachVolume(datacenter.Id, server.Id, volume.Id);
            Assert.IsNull(resp);
        }

        [TestMethod]
        public void ServerAttachCDROM()
        {
            sourceCDROM = TestHelper.GetImage("ubuntu", "CDROM", Config.DefaultLocation);
            Assert.IsNotNull(sourceCDROM);

            attachedCDROM = attachCDROMApi.Attach(datacenter.Id, server.Id, new Image { Id=sourceCDROM.Id});
            Config.DoWait(attachedCDROM.Request);

            Assert.AreEqual(attachedCDROM.Id, sourceCDROM.Id);
            Assert.AreEqual(attachedCDROM.Properties.Name, sourceCDROM.Properties.Name);
        }

        [TestMethod]
        public void ServerListAttachedCDROMs()
        {
            var listAttached = attachCDROMApi.FindAll(datacenter.Id, server.Id);
            Assert.IsTrue(listAttached.Items.Count > 0);
        }

        [TestMethod]
        public void ServerGetAttachedCDROM()
        {
            var resp = attachCDROMApi.FindById(datacenter.Id, server.Id, attachedCDROM.Id);
            Assert.AreEqual(attachedCDROM.Id, resp.Id);
            Assert.AreEqual(attachedCDROM.Properties.Name, resp.Properties.Name);
        }

        [TestMethod]
        public void ServerDetachCDROM()
        {
            var removed = attachCDROMApi.Detach(datacenter.Id, server.Id, attachedCDROM.Id);
            Assert.IsNull(removed);
        }

        [TestMethod]
        public void ServerDelete()
        {
            var response = serverApi.Delete(datacenter.Id, server.Id);
            Assert.IsNull(response);

            response = dcApi.Delete(datacenter.Id);
            Assert.IsNull(response);
        }
    }
}

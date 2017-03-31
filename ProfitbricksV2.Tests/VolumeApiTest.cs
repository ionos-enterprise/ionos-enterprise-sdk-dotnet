using Api;
using Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ProfitbricksV2.Tests
{
    [TestClass]
    public class VolumeApiTest
    {
        DataCenterApi dcApi = new DataCenterApi(Config.Configuration);
        ServerApi serverApi = new ServerApi(Config.Configuration);
        VolumeApi volumeApi = new VolumeApi(Config.Configuration);
        AttachedVolumesApi attachedVolumesApi = new AttachedVolumesApi(Config.Configuration);
        static Datacenter datacenter;
        static Server server;
        static Volume volume;

        [TestInitialize]
        public void VolumeCreate()
        {
            datacenter = new Datacenter
            {
                Properties = new DatacenterProperties
                {
                    Name = ".Net V2 - Volume Test " + DateTime.Now.ToShortTimeString(),
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

            server = datacenter.Entities.Servers.Items[0];

            Assert.IsNotNull(server);

            volume = new Volume
            {
                Properties = new VolumeProperties
                {
                    Size = 4,
                    LicenceType = "UNKNOWN",
                    Type = "HDD",
                    Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString(),
                    AvailabilityZone = "ZONE_3"
                }
            };
            volume = volumeApi.Create(datacenter.Id, volume, depth: 5);

            Assert.IsNotNull(volume);
            Assert.AreEqual(volume.Properties.AvailabilityZone, "ZONE_3");
            Config.DoWait(volume.Request);
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void DataCenterGetFail()
        {
            try
            {
                volume = new Volume
                {
                    Properties = new VolumeProperties
                    {
                        Size = 4,
                        LicenceType = "UNKNOWN",
                        Type = "HDD",
                        Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString(),
                        AvailabilityZone = "ZONE_3"
                    }
                };
                volume = volumeApi.Create(datacenter.Id, volume, depth: 5);

                var vol = volumeApi.Create("rawera", volume, depth: 5);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ApiException);
            }
        }

        [TestMethod]
        public void VolumeGet()
        {
            var newVolume = volumeApi.FindById(datacenter.Id, volume.Id);

            Assert.IsNotNull(newVolume);
        }

        [TestMethod]
        public void VolumeList()
        {
            var list = volumeApi.FindAll(datacenter.Id);

            Assert.IsTrue(list.Items.Count > 0);
        }

        [TestMethod]
        public void VolumeUpdate()
        {
            var newProps = new VolumeProperties { Size = volume.Properties.Size + 1 };

            var newVolume = volumeApi.PartialUpdate(datacenter.Id, volume.Id, newProps);

            Config.DoWait(newVolume.Request);

            newVolume = volumeApi.FindById(datacenter.Id, volume.Id);

            Assert.AreEqual(newVolume.Properties.Size, volume.Properties.Size + 1);
            volume = newVolume;
        }

        [TestMethod]
        public void VolumeAttach()
        {
            var resp = attachedVolumesApi.AttachVolume(datacenter.Id, server.Id, new Volume { Id = volume.Id });

            Config.DoWait(resp.Request);

            var attachedVol = attachedVolumesApi.FindById(datacenter.Id, server.Id, volume.Id);
            Assert.IsNotNull(attachedVol);

            var resp1 = attachedVolumesApi.DetachVolume(datacenter.Id, server.Id, volume.Id);

            Assert.IsNull(resp1);
        }

        [TestCleanup]
        public void VolumeDelete()
        {
            var response = volumeApi.Delete(datacenter.Id, volume.Id);
            Assert.IsNull(response);

            response = dcApi.Delete(datacenter.Id);
            Assert.IsNull(response);
        }
    }
}

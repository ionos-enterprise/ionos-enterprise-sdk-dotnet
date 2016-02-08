using Api;
using Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Threading;
using System.Linq;

namespace ProfitbricksV2.Tests
{
    [TestClass]
    public class VolumeApiTest
    {
        Configuration configuration;
        DataCenterApi dcApi;
        ServerApi serverApi;
        VolumeApi volumeApi;
        AttachedVolumesApi attachedVolumesApi;
        static Datacenter datacenter;
        static Server server;
        static Volume volume;

        string imageId = "fbaae2b2-c899-11e5-aa10-52540005ab80";

        private void Configure()
        {
            configuration = new Configuration
            {
                Username = "muhamed@stackpointcloud.com",
                Password = "test123!",
            };

            dcApi = new DataCenterApi(configuration);
            serverApi = new ServerApi(configuration);
            volumeApi = new VolumeApi(configuration);
            attachedVolumesApi = new AttachedVolumesApi(configuration);

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
            if (server == null)
            {
                server = new Server
                {
                    Properties = new ServerProperties
                    {
                        Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString(),
                        Cores = 1,
                        Ram = 1024
                    }
                };

                server = serverApi.Create(datacenter.Id, server);

                DoWait(server.Request);
            }

        }

        [TestMethod]
        public void VolumeCreate()
        {
            Configure();
            volume = new Volume
            {
                Properties = new VolumeProperties
                {
                    Size = 4,
                    Image = imageId,
                    Type = "HDD",
                    Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString(),
                }
            };
            volume = volumeApi.Create(datacenter.Id, volume);

            bool isBusy = true;

            while (isBusy == true)
            {
                var dc = dcApi.FindById(datacenter.Id);
                if (dc.Metadata.State != "BUSY") isBusy = false;
                Thread.Sleep(1500);
            }

            Assert.IsNotNull(volume);
        }

        [TestMethod]
        public void VolumeGet()
        {
            Configure();

            var newVolume = volumeApi.FindById(datacenter.Id, volume.Id);

            Assert.IsNotNull(newVolume);
        }

        [TestMethod]
        public void VolumeList()
        {
            Configure();

            var list = volumeApi.FindAll(datacenter.Id);

            Assert.IsTrue(list.Items.Count > 0);
        }

        [TestMethod]
        public void VolumeUpdate()
        {
            Configure();
            var newProps = new VolumeProperties { Size = volume.Properties.Size + 1 };

            var newVolume = volumeApi.PartialUpdate(datacenter.Id, volume.Id, newProps);

            DoWait(newVolume.Request);

            bool isBusy = true;

            while (isBusy == true)
            {
                var dc = dcApi.FindById(datacenter.Id);
                if (dc.Metadata.State != "BUSY") isBusy = false;
                Thread.Sleep(2000);
            }

            isBusy = true;

            while (isBusy == true)
            {
                newVolume = volumeApi.FindById(datacenter.Id, volume.Id);
                if (newVolume.Metadata.State != "BUSY") isBusy = false;
                Thread.Sleep(2000);
            }

            newVolume = volumeApi.FindById(datacenter.Id, volume.Id);

            Assert.AreEqual(newVolume.Properties.Size, volume.Properties.Size + 1);
            volume = newVolume;
        }

        [TestMethod]
        public void VolumeAttach()
        {
            Configure();
            var resp = attachedVolumesApi.AttachVolume(datacenter.Id, server.Id, new Volume { Id = volume.Id });

            DoWait(resp.Request);


            bool isBusy = true;

            while (isBusy == true)
            {
                var dc = dcApi.FindById(datacenter.Id);
                if (dc.Metadata.State != "BUSY") isBusy = false;
                Thread.Sleep(2000);
            }

            var list = attachedVolumesApi.FindAll(datacenter.Id, server.Id);
            var vol = list.Items.Where(v => v.Id == volume.Id).FirstOrDefault();

            var serv = serverApi.PartialUpdate(datacenter.Id, server.Id, new ServerProperties { BootVolume = new ResourceReference { Id = vol.Id } });
            Assert.AreEqual(vol.Id, volume.Id);

        }

        [TestMethod]
        public void VolumeDetach()
        {
            Configure();
            var resp = attachedVolumesApi.DetachVolume(datacenter.Id, server.Id, volume.Id);

            Assert.IsNull(resp);
        }

        [TestMethod]
        public void VolumeDelete()
        {
            Configure();
            var response = volumeApi.Delete(datacenter.Id, volume.Id);

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
                if (counter == 35)
                    break;
                else if (request.Metadata.Status == "FAILED")
                    throw new Exception(request.Metadata.Message);
            } while (request.Metadata.Status != "DONE" && counter != 35);
        }
    }
}

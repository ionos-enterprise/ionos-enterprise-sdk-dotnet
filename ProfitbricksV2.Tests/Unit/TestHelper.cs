using Api;
using Model;
using System.Collections.Generic;

namespace ProfitBricksSDK.Tests
{
    public static class TestHelper
    {
        public static Datacenter CreateDatacenter(
            string name = Config.DefaultName,
            string description = null,
            string location = Config.DefaultLocation,
            DatacenterEntities entities = null)
        {
            var datacenter = new Datacenter
            {
                Properties = new DatacenterProperties
                {
                    Name = name,
                    Description = description,
                    Location = location
                },
                Entities = entities
            };

            DataCenterApi dcApi = new DataCenterApi(Config.Configuration);

            datacenter = dcApi.Create(datacenter, depth: 5);
            Config.DoWait(datacenter.Request);

            return datacenter;
        }

        public static Image GetImage(string name, string type, string location)
        {
            ImageApi imageApi = new ImageApi(Config.Configuration);

            return imageApi.FindAll(depth: 1)
                .Items.Find(i => i.Properties.Location == location && i.Properties.ImageType == type && i.Properties.Name.Contains(name));
        }

        public static Servers BuildServers()
        {
            return new Servers
            {
                Items = new List<Server>
                {
                    new Server
                    {
                        Properties = new ServerProperties
                        {
                            Name = Config.DefaultName,
                            Cores = 1,
                            Ram = 1024,
                        }
                    }
                }
            };
        }

        public static Volumes BuildVolumes()
        {
            return new Volumes
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
                            LicenceType = "UNKNOWN",
                            AvailabilityZone = "ZONE_3"
                        }
                    }
                }
            };
        }

    }
}

using Api;
using Client;
using Model;
using System;

namespace ProfitbricksV2.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration
            {
                Username = "jasmin.gacic@gmail.com",
                Password = "magribija123!",

            };
            var dcApi = new DataCenterApi(configuration);
            var serverApi = new ServerApi(configuration);
            var volumeApi = new VolumeApi(configuration);
            var attachedVolumesApi = new AttachedVolumesApi(configuration);
            var nicApi = new NetworkInterfacesApi(configuration);


            // CreateDataCenterRequest. 
            // The only required field is DataCenterName. 
            // If location parameter is left empty data center will be created in the default region of the customer
            var datacenter = new Datacenter
            {
                Properties = new DatacenterProperties
                {
                    Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString(),
                    Description = "Unit test for .Net SDK PB REST V2",
                    Location = "us/las"
                }
            };

            // Response will contain Id of a newly created data center.
            datacenter = dcApi.Create(datacenter);

            // CreateServer. 
            // DataCenterId: Defines the data center wherein the server is to be created.
            // AvailabilityZone: Selects the zone in which the server is going to be created (AUTO, ZONE_1, ZONE_2).
            // Cores: Number of cores to be assigned to the specified server. Required field.
            // InternetAccess: Set to TRUE to connect the server to the Internet via the specified LAN ID.
            // OsType: Sets the OS type of the server.
            // Ram: Number of RAM memory (in MiB) to be assigned to the server.
            var server = new Server
            {
                Properties = new ServerProperties
                {
                    Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString(),
                    Cores = 1,
                    Ram = 256,
                    CpuFamily = "INTEL_XEON"
                }
            };

            // response will contain Id of a newly created server.
            server = serverApi.Create(datacenter.Id, server);

            // UpdateServer
            // ServerId: Id of the server to be updated.
            // ServerName: Renames target virtual server
            // Cores: Updates the amount of cores of the target virtual server
            // Ram: Updates the RAM memory (in MiB) of the target virtual server. The minimum RAM size is 256 MiB
            server = serverApi.PartialUpdate(datacenter.Id, server.Id, new ServerProperties { Name = server.Properties.Name + " -Updated" });


            // CreateVolume
            // DataCenterId: Defines the data center wherein the storage is to be created. If left empty, the storage will be created in a new data center
            // Size: Storage size (in GiB). Required Field.
            // Type: SSD or HDD disk type, Required Field
            var volume = new Volume
            {
                Properties = new VolumeProperties
                {
                    Size = 4,
                    Image = "fbaae2b2-c899-11e5-aa10-52540005ab80",
                    Type = "HDD",
                    Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString(),
                    SshKeys = new System.Collections.Generic.List<string> { "hQGOEJeFL91EG3+l9TtRbWNjzhDVHeLuL3NWee6bekA=" }
                }
            };

            // Response will contain Id of a newly created volume.
            volume = volumeApi.Create(datacenter.Id, volume);

            // AttachVolume
            // ServerId: Identifier of the target virtual storage. Required field.
            // StorageId: Identifier of the virtual storage to be connected. Required field.
            // BusType: Bus type to which the storage will be connected
            attachedVolumesApi.AttachVolume(datacenter.Id, server.Id, new Volume { Id = volume.Id });

            attachedVolumesApi.DetachVolume(datacenter.Id, server.Id, volume.Id);

            // Fetches list of all Data Centers
            var dcs = dcApi.FindAll(depth: 5);

            // Fetches list of all Servers
            var servers = serverApi.FindAll(datacenter.Id, depth: 5);

            // Fetches list of all Volumes
            var volumes = volumeApi.FindAll(datacenter.Id, depth: 5);

            // CreateNicRequest
            // Identifier of the target virtual server. Required field.
            // Nic: Names the NIC
            // Toggles usage of ProfitBricks DHCP
            // Lan
            var nic = new Nic { Properties = new NicProperties { Lan = 1 , Dhcp = true, Name = "Nic name"} };

            nic = nicApi.Create(datacenter.Id, server.Id, nic);

        }
    }
}

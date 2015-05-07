using ProfitBricks.Client;
using ProfitBricks.POCO.Enums;
using ProfitBricks.POCO.Requests;

namespace ProfitBricksExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // CreateDataCenterRequest. 
            // The only required field is DataCenterName. 
            // If location parameter is left empty data center will be created in the default region of the customer
            var dcCreateRequest = new CreateDataCenterRequest
            {
                DataCenterName = "test",
                Location = ProfitBricks.POCO.Enums.Location.uslas
            };

            // Response will contain Id of a newly created data center.
            var dcCreateResponse = ProfitBricksSoapClient.Instance.DataCenters.Create(dcCreateRequest);

            // CreateServerRequest. 
            // DataCenterId: Defines the data center wherein the server is to be created.
            // AvailabilityZone: Selects the zone in which the server is going to be created (AUTO, ZONE_1, ZONE_2).
            // Cores: Number of cores to be assigned to the specified server. Required field.
            // InternetAccess: Set to TRUE to connect the server to the Internet via the specified LAN ID.
            // OsType: Sets the OS type of the server.
            // Ram: Number of RAM memory (in MiB) to be assigned to the server.
            var serverCreateRequest = new CreateServerRequest
            {
                DataCenterId = dcCreateResponse.Id,
                AvailabilityZone = AvailabilityZone.AUTO,
                Cores = 4,
                InternetAccess = true,
                OsType = OsType.WINDOWS,
                Ram = 256
            };

            // response will contain Id of a newly created server.
            var createServerResponse = ProfitBricksSoapClient.Instance.Servers.Create(serverCreateRequest);

            // UpdateServerRequest
            // ServerId: Id of the server to be updated.
            // ServerName: Renames target virtual server
            // Cores: Updates the amount of cores of the target virtual server
            // Ram: Updates the RAM memory (in MiB) of the target virtual server. The minimum RAM size is 256 MiB
            var updateServerRequest = new UpdateServerRequest
            {
                ServerId = createServerResponse.Id,
                ServerName = "newName",
                Cores = 3,
                Ram = 512
            };

            ProfitBricksSoapClient.Instance.Servers.Update(updateServerRequest);

            // CreateVolumeRequest
            // DataCenterId: Defines the data center wherein the storage is to be created. If left empty, the storage will be created in a new data center
            // Size: Storage size (in GiB). Required Field.
            var createVolumeRequest = new CreateVolumeRequest
            {
                DataCenterId = dcCreateResponse.Id,
                Size = 1
            };

            // Response will contain Id of a newly created volume.
            var createVolumeResponse = ProfitBricksSoapClient.Instance.Volumes.Create(createVolumeRequest);

            // ConnectStorageRequest
            // ServerId: Identifier of the target virtual storage. Required field.
            // StorageId: Identifier of the virtual storage to be connected. Required field.
            // BusType: Bus type to which the storage will be connected
            var connectStorageRequest = new ConnectStorageRequest
            {
                ServerId = createServerResponse.Id,
                StorageId = createVolumeResponse.Id,
                BusType = BusType.SCSI,
            };

            ProfitBricksSoapClient.Instance.Volumes.ConnectVolume(connectStorageRequest);

            ProfitBricksSoapClient.Instance.Volumes.DisconnectVolume(createVolumeResponse.Id, createServerResponse.Id);

            // Fetches list of all DataCenters
            var dcs = ProfitBricksSoapClient.Instance.DataCenters.Get();

            // Fetches list of all Servers
            var servers = ProfitBricksSoapClient.Instance.Servers.Get();

            // Fetches list of all Volumes
            var volumes = ProfitBricksSoapClient.Instance.Volumes.Get();

            // CreateNicRequest
            // Identifier of the target virtual server. Required field.
            // NicName: Names the NIC
            // Toggles usage of ProfitBricks DHCP
            var createNicRequest = new CreateNicRequest
            {
                ServerId = createServerResponse.Id,
                NicName = "new nic name",
                DhcpActive = true
            };

            ProfitBricksSoapClient.Instance.Nics.Create(createNicRequest);
        }
    }
}
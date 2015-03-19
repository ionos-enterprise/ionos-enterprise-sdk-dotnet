using ProfitBricks.POCO.Enums;

namespace ProfitBricks.POCO.Requests
{
    /// <summary>
    /// CreateServerRequest
    /// </summary>
    public class CreateServerRequest : ProfitBricksBase
    {
        /// <summary>
        /// Defines the data center wherein the server is to be created. If left empty, the server will be created in a new data center
        /// </summary>
        public string DataCenterId { get; set; }

        /// <summary>
        /// Number of cores to be assigned to the specified server. Required field.
        /// </summary>
        public int Cores { get; set; }

        /// <summary>
        /// Number of RAM memory (in MiB) to be assigned to the server. The size is specified in multiples of 256 MiB with a minimum of 256 MiB. Required field.
        /// </summary>
        public int Ram { get; set; }

        /// <summary>
        /// Name of the server to be created
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// Defines an existing storage device ID to be set as boot device of the server. The storage will be connected to the server implicitly.
        /// If not left empty, the bus type to which the storage will be connected is VIRTIO. For a different bus type a subsequent invocation of connectStorageToServer operation is required, with busType as a parameter.
        /// </summary>
        public string BootFromStorageId { get; set; }

        /// <summary>
        /// Defines an existing CD-ROM/DVD image ID to be set as boot device of the server. A virtual CD-ROM/DVD drive with the mounted image will be connected to the server.
        /// </summary>
        public string BootFromImageId { get; set; }

        /// <summary>
        /// Set to TRUE to connect the server to the Internet via the specified LAN ID. If the LAN is not specified, it is going to be created in the next available LAN ID, starting with LAN ID 1
        /// </summary>
        public bool InternetAccess { get; set; }

        /// <summary>
        /// Connects the server to the specified LAN ID > 0. If the respective LAN does not exist, it is going to be created
        /// </summary>
        public int LanId { get; set; }

        /// <summary>
        /// Sets the OS type of the server. (WINDOWS, LINUX, OTHER, UNKNOWN)
        /// If left empty, the server will inherit the OS Type of its selected boot image / storage
        /// </summary>
        public OsType OsType { get; set; }

        /// <summary>
        /// Selects the zone in which the server is going to be created (AUTO, ZONE_1, ZONE_2). Servers from different zones are located in different physical locations. If set to AUTO or left empty, servers will be created in a random zone
        /// </summary>
        public AvailabilityZone AvailabilityZone { get; set; }
    }
}

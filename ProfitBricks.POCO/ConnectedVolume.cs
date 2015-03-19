using ProfitBricks.POCO.Enums;

namespace ProfitBricks.POCO
{
    /// <summary>
    /// ConnectedVolume
    /// </summary>
    public class ConnectedVolume : ProfitBricksBase
    {
        /// <summary>
        /// a flag, indicating whether server is booting from this storage or not [TRUE/FALSE]
        /// </summary>
        public bool BootDevice { get; set; }

        /// <summary>
        /// Bus type to which the storage is connected
        /// </summary>
        public BusType BusType { get; set; }

        /// <summary>
        /// device number the storage is connected
        /// </summary>
        public int DeviceNumber { get; set; }

        /// <summary>
        /// storage size (in GiB)
        /// </summary>
        public long Size { get; set; }

        /// <summary>
        ///  storage identifier
        /// </summary>
        public string StorageId { get; set; }

        /// <summary>
        /// name of the storage
        /// </summary>
        public string StorageName { get; set; }
    }
}

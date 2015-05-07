using ProfitBricks.POCO.Enums;

namespace ProfitBricks.POCO.Requests
{
    /// <summary>
    /// Connect storage request.
    /// </summary>
    public class ConnectStorageRequest : ProfitBricksBase
    {
        /// <summary>
        /// Identifier of the target virtual storage. Required field.
        /// </summary>
        public string ServerId { get; set; }

        /// <summary>
        /// Identifier of the virtual storage to be connected. Required field.
        /// </summary>
        public string StorageId { get; set; }

        /// <summary>
        /// Bus type to which the storage will be connected
        /// Default Type is VIRTIO
        /// Type can be IDE or VIRTIO (BusType SCSI will be supported in the future)
        /// </summary>
        public BusType BusType { get; set; }

        /// <summary>
        /// Defines the device number of the virtual storage. If no device number is set, a device number will be automatically assigned
        /// </summary>
        public int DeviceNumber { get; set; }
    }
}


namespace ProfitBricks.POCO.Requests
{
    /// <summary>
    /// CreateStorageRequest.
    /// </summary>
    public class CreateVolumeRequest : ProfitBricksBase
    {
        /// <summary>
        /// Defines the data center wherein the storage is to be created. If left empty, the storage will be created in a new data center
        /// </summary>
        public string DataCenterId { get; set; }

        /// <summary>
        /// Name of the storage to be created
        /// </summary>
        public string StorageName { get; set; }

        /// <summary>
        /// Storage size (in GiB). Required Field.
        /// </summary>
        public long Size { get; set; }

        /// <summary>
        /// Specifies the HDD image to be assigned to the storage by its ID
        /// </summary>
        public string MountImageId { get; set; }

        /// <summary>
        /// Sets the VM image root login password to the specified value. Only supported for generic Profitbricks HDD images. User images are expected to be preconfigured with a password. If no password is supplied, one is automatically created. Please see error codes for password syntax rules.
        /// password must be between 8 and 50 characters, only a-z, A-Z, 0-9 without  characters i, I, l, o, O, w, W, y, Y, z, Z and 1, 0
        /// </summary>
        public string ProfitBricksImagePassword { get; set; }
    }
}

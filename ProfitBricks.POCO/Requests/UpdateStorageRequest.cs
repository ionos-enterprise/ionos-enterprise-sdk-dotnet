
namespace ProfitBricks.POCO.Requests
{
    /// <summary>
    /// UpdateStorageRequest
    /// </summary>
    public class UpdateStorageRequest : ProfitBricksBase
    {
        /// <summary>
        ///Identifier of the target virtual storage. This is a required field.
        /// </summary>
        public string StorageId { get; set; }

        /// <summary>
        /// Updates the size of the storage (in GiB)
        /// </summary>
        public long Size { get; set; }

        /// <summary>
        /// Renames the target virtual storage
        /// </summary>
        public string StorageName { get; set; }

        /// <summary>
        /// Specifies the HDD image to be assigned to the storage by its ID
        /// </summary>
        public string MountImageId { get; set; }
    }
}

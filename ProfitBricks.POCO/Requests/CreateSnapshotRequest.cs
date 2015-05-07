
namespace ProfitBricks.POCO.Requests
{
    /// <summary>
    /// CreateSnapshotRequest
    /// </summary>
    public class CreateSnapshotRequest : ProfitBricksBase
    {
        /// <summary>
        /// Identifier of the virtual storage for which a snapshot shall be created
        /// </summary>
        public string StorageId { get; set; }

        /// <summary>
        /// Additional field to provide customized information about the data in this snapshot
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Name of the snapshot to be created
        /// </summary>
        public string SnapshotName { get; set; }
    }
}

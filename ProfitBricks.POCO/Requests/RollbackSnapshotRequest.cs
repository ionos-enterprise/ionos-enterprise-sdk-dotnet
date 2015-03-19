
namespace ProfitBricks.POCO.Requests
{
    /// <summary>
    /// RollbackSnapshotRequest 
    /// </summary>
    public class RollbackSnapshotRequest : ProfitBricksBase
    {
        /// <summary>
        /// Identifier of the virtual storage as target for the snapshot. Required field.
        /// </summary>
        public string StorageId { get; set; }

        /// <summary>
        /// Identifier of the snapshot that shall get deployed on a virtual storage. Required field.
        /// </summary>
        public string SnapshotId { get; set; }
    }
}

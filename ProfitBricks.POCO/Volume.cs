using System.Collections.Generic;

namespace ProfitBricks.POCO
{
    /// <summary>
    /// Volume calss that is represented in PB API as storage.
    /// </summary>
    public class Volume : ProfitBricksBase
    {
        /// <summary>
        /// StorageId
        /// </summary>
        public string StorageId { get; set; }
        
        /// <summary>
        /// Volume size.
        /// </summary>
        public long Size { get; set; }
        
        /// <summary>
        /// StorageName
        /// </summary>
        public string StorageName { get; set; }
        
        /// <summary>
        /// MountImage
        /// </summary>
        public MountImage MountImage { get; set; }
        
        /// <summary>
        /// List of server id associated with the Volume.
        /// </summary>
        public List<string> serverIds { get; set; }

        /// <summary>
        /// CreationTime
        /// </summary>
        public System.DateTime CreationTime { get; set; }
        
        /// <summary>
        /// LastModificationTime
        /// </summary>
        public System.DateTime LastModificationTime { get; set; }
    }
}

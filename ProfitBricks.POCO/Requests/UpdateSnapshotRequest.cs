using ProfitBricks.POCO.Enums;

namespace ProfitBricks.POCO.Requests
{
    /// <summary>
    /// UpdateShapshotRequest class.
    /// </summary>
    public class UpdateSnapshotRequest : ProfitBricksBase
    {
        /// <summary>
        /// Identifier of the snapshot that shall get updated
        /// </summary>
        public string SnapshotId { get; set; }

        /// <summary>
        /// text field to add additional information (e.g. for details about time or reason why snapshot was created)
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// Name of snapshot
        /// </summary>
        public string SnapshotName { get; set; }
        
        /// <summary>
        /// Flag of type boolean
        /// </summary>
        public bool Bootable { get; set; }
        
        /// <summary>
        /// Flag to specify OS type; relevant for license accounting in case snapshot gets redeployed on further virtual storage instances (WINDOWS, LINUX, OTHER, UNKNOWN)
        /// </summary>
        public OsType OsType { get; set; }
        
        /// <summary>
        /// snapshot contains capabilities to hotplug CPU; flag of type boolean*
        /// </summary>
        public bool CpuHotPlug { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public bool CpuHotUnPlug { get; set; }
        
        /// <summary>
        /// Snapshot contains capabilities to hotplug RAM; flag of type boolean
        /// </summary>
        public bool RamHotPlug { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public bool RamHotUnPlug { get; set; }
        
        /// <summary>
        /// snapshot contains capabilities to hotplug NIC; flag of type boolean
        /// </summary>
        public bool NicHotPlug { get; set; }
        
        /// <summary>
        /// snapshot contains capabilities to hotunplug NIC; flag of type boolean
        /// </summary>
        public bool NicHotUnPlug { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DiscVirtioHotPlug { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DiscVirtioHotUnPlug { get; set; }
    }
}

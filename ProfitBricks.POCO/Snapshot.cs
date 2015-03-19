using ProfitBricks.POCO.Enums;

namespace ProfitBricks.POCO
{
    /// <summary>
    /// Snapshot
    /// </summary>
    public class Snapshot : ProfitBricksBase
    {
        /// <summary>
        /// Identifier of the snapshot
        /// </summary>
        public string SnapshotId { get; set; }

        /// <summary>
        /// text data that can provide additional data about a snapshot
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// size of the snapshot 
        /// </summary>
        public long SnapshotSize { get; set; }

        /// <summary>
        /// name of the snapshot
        /// </summary>
        public string SnapshotName { get; set; }

        /// <summary>
        /// flag to identify boot capabilities of a snapshot; flag of type boolean
        /// </summary>
        public bool Bootable { get; set; }

        /// <summary>
        /// flag of currently set OS type of the snapshot (WINDOWS, LINUX, OTHER, UNKNOWN)
        /// </summary>
        public OsType OsType { get; set; }

        /// <summary>
        /// snapshot contains capabilities to hotplug CPU; flag of type boolean
        /// </summary>
        public bool CpuHotPlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool CpuHotUnPlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool DiscVirtioHotPlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool DiscVirtioHotUnPlug { get; set; }

        /// <summary>
        /// snapshot contains capabilities to hotplug RAM; flag of type boolean
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
        /// 
        /// </summary>
        public bool NicHotUnPlug { get; set; }

        /// <summary>
        /// Time when the specified snapshot has been created
        /// </summary>
        public System.DateTime CreationTimestamp { get; set; }

        /// <summary>
        /// Time when the specified snapshot has last been modified
        /// </summary>
        public System.DateTime ModificationTimestamp { get; set; }

        /// <summary>
        /// name of region in which the snapshot is available; it cannot be used in any other region than that
        /// </summary>
        public Location Location { get; set; }
    }
}

using ProfitBricks.POCO.Enums;

namespace ProfitBricks.POCO.Requests
{
    /// <summary>
    /// UpdateImageRequest
    /// </summary>
    public class UpdateImageRequest : ProfitBricksBase
    {
        /// <summary>
        /// Identifier of the target image
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// Name of the image
        /// </summary>
        public string ImageName { get; set; }

        /// <summary>
        /// An option to provide own description to the image
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// OS Type of the target image (WINDOWS, LINUX, OTHER,UNKNOWN)
        /// </summary>
        public OsType OsType { get; set; }

        /// <summary>
        /// image contains capabilities to hotplug CPU; flag of type boolean
        /// </summary>
        public bool CpuHotPlug { get; set; }

        /// <summary>
        /// Not supported yet
        /// </summary>
        public bool CpuHotUnPlug { get; set; }

        /// <summary>
        /// image contains capabilities to hotplug RAM; flag of type boolean
        /// </summary>
        public bool RamHotPlug { get; set; }

        /// <summary>
        /// Not supported yet
        /// </summary>
        public bool RamHotUnPlug { get; set; }

        /// <summary>
        /// image contains capabilities to hotplug NIC; flag of type boolean
        /// </summary>
        public bool NicHotPlug { get; set; }

        /// <summary>
        /// image contains capabilities to hotunplug NIC; flag of type boolean
        /// </summary>
        public bool NicHotUnPlug { get; set; }

        /// <summary>
        /// image contains capabilities to hotplug storages which are connected through VirtIO bustype; flag of type boolean
        /// </summary>
        public bool DiscVirtioHotPlug { get; set; }

        /// <summary>
        /// image contains capabilities to hotunplug storages which are connected through VirtIO bustype; flag of type boolean
        /// </summary>
        public bool DiscVirtioHotUnPlug { get; set; }

        /// <summary>
        /// image contains capabilities to boot from; flag of type boolean
        /// </summary>
        public bool Bootable { get; set; }
    }
}

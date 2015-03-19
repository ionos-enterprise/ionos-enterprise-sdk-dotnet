using ProfitBricks.POCO.Enums;

namespace ProfitBricks.POCO.Requests
{
    /// <summary>
    /// UpdateServerRequest
    /// </summary>
    public class UpdateServerRequest : ProfitBricksBase
    {
        /// <summary>
        /// Identifier of the target virtual server. Required field.
        /// </summary>
        public string ServerId { get; set; }

        /// <summary>
        /// Renames the target virtual server
        /// </summary>
        public string ServerName{ get; set; }

        /// <summary>
        /// Updates the amount of cores of the target virtual server
        /// </summary>
        public int Cores{ get; set; }

        /// <summary>
        /// Updates the RAM memory (in MiB) of the target virtual server. The minimum RAM size is 256 MiB
        /// </summary>
        public int Ram{ get; set; }
        
        /// <summary>
        /// Defines an existing CD-ROM/DVD (ISO) image ID to be set as boot device of the server. A virtual CD-ROM/DVD drive with the mounted image will be connected to the server implicitly. 
        /// </summary>
        public string BootFromStorageId{ get; set; }
        
        /// <summary>
        /// Defines an existing storage device ID to be set as boot device of the server. The storage will be connected to the server implicitly.
        /// </summary>
        public string BootFromImageId{ get; set; }
        
        /// <summary>
        /// Updates OS Type of the target server (WINDOWS, LINUX, OTHER, UNKOWN)
        /// </summary>
        public OsType OsType{ get; set; }
        
        /// <summary>
        /// Zone in which the server is located (AUTO, ZONE_1, ZONE_2)
        /// </summary>
        public AvailabilityZone AvailabilityZone{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool CpuHotPlug{ get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public bool RamHotPlug{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool NicHotPlug{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool NicHotUnPlug{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool DiscVirtioHotPlug{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool DiscVirtioHotUnPlug{ get; set; }
    }
}
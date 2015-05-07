using ProfitBricks.POCO.Enums;
using System.Collections.Generic;

namespace ProfitBricks.POCO
{
    /// <summary>
    /// Image
    /// </summary>
    public class Image : ProfitBricksBase
    {
        /// <summary>
        /// 
        /// </summary>
        public bool Bootable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool CpuHotPlug { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool CpuHotUnPlug { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool DiscVirtioHotPlug { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool DiscVirtioHotUnPlug { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ImageId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ImageName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long ImageSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ImageType ImageType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Location Location { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool NicHotPlug { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool NicHotUnPlug { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public OsType OsType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Public { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool RamHotPlug { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool RamHotUnPlug { get; set; }

        /// <summary>
        /// Lists all servers (by ID) on which the specified CD-ROM/DVD image is being used.
        /// </summary>
        public List<string> ServerIds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Writeable { get; set; }
    }
}

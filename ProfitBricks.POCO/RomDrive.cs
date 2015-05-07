
namespace ProfitBricks.POCO
{

    /// <summary>
    /// RomDrive
    /// </summary>
    public class RomDrive : ProfitBricksBase
    {
        /// <summary>
        /// Indicates if device is boot device or not.
        /// </summary>
        public bool BootDevice { get; set; }
        
        /// <summary>
        /// Identifier of the CD-ROM/DVD image
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// Image name
        /// </summary>
        public string ImageName { get; set; }
    }
}

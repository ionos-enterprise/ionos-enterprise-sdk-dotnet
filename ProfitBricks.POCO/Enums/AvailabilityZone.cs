
namespace ProfitBricks.POCO.Enums
{
    /// <summary>
    /// Selects the zone in which the server is going to be created (AUTO, ZONE_1, ZONE_2). Servers from different zones are located in different physical locations. If set to AUTO or left empty, servers will be created in a random zone
    /// </summary>
    public enum AvailabilityZone
    {
        /// <summary>
        /// 
        /// </summary>
        AUTO,
        /// <summary>
        /// 
        /// </summary>
        ZONE_1,
        /// <summary>
        /// 
        /// </summary>
        ZONE_2,
    }
}

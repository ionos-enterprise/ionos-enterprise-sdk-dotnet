using ProfitBricks.POCO.Enums;

namespace ProfitBricks.POCO.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateReservePublicIpBlockRequest : ProfitBricksBase
    {
        /// <summary>
        /// Block size / amount of IPs to reserve
        /// </summary>
        public int BlockSize { get; set; }

        /// <summary>
        /// Select region of reserved IP block (NORTH_AMERICA, EUROPE, DEFAULT)
        /// If set to DEFAULT or left empty, IPs will be reserved in the customer's default region
        /// </summary>
        public Location Location { get; set; }
    }
}

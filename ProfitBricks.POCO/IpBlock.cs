using ProfitBricks.POCO.Enums;
using System.Collections.Generic;

namespace ProfitBricks.POCO
{
    /// <summary>
    /// 
    /// </summary>
    public class IpBlock : ProfitBricksBase
    {
        /// <summary>
        /// Identifier of the IP block
        /// </summary>
        public string BlockId { get; set; }

        /// <summary>
        /// Region where the IP block has been reserved for use (NORTH_AMERICA, EUROPE)
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// Identifier of the public IPs within the respective block, including their IP and (if assigned to a NIC) the respective NIC ID
        /// </summary>
        public List<PublicIpBlock> PublicIps { get; set; }
    }
}

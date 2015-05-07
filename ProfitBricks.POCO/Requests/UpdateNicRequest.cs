using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProfitBricks.POCO.Requests
{
    /// <summary>
    /// UpdateNicRequest
    /// </summary>
    public class UpdateNicRequest : ProfitBricksBase
    {
        /// <summary>
        /// Identifier of the target NIC. Required Field.
        /// </summary>
        public string NicId { get; set; }

        /// <summary>
        /// Identifier of the target LAN connected to the NIC. If no LAN exists for such ID, a new LAN with the given ID will be created.
        /// To disconnect a NIC from a LAN, set LAN ID to 0
        /// </summary>
        public int LanId { get; set; }

        /// <summary>
        /// Names the NIC
        /// </summary>
        public string NicName { get; set; }

        /// <summary>
        /// Public/private IP address. Set to empty to reset the IP address. 
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// Toggles usage of ProfitBricks DHCP
        /// </summary>
        public bool DhcpActive { get; set; }
    }
}

using System.Collections.Generic;

namespace ProfitBricks.POCO
{
    /// <summary>
    /// Nic
    /// </summary>
    public class Nic : ProfitBricksBase
    {
        /// <summary>
        /// Identifier of the virtual NIC
        /// </summary>
        public string NicId { get; set; }

        /// <summary>
        /// NIC name
        /// </summary>
        public string NicName { get; set; }

        /// <summary>
        /// Identifier of the target LAN
        /// </summary>
        public int LanId { get; set; }

        /// <summary>
        /// Internet Access (TRUE/FALSE)
        /// </summary>
        public bool InternetAccess { get; set; }

        /// <summary>
        /// Identifier of the target server
        /// </summary>
        public string ServerId { get; set; }

        /// <summary>
        /// Lists all public and private IP addresses assigned to the NIC
        /// </summary>
        public List<string> Ips { get; set; }

        /// <summary>
        /// MAC address (automatically) assigned to the NIC
        /// </summary>
        public string MacAddress { get; set; }

        /// <summary>
        /// Lists all firewall rules applied to the NIC
        /// </summary>
        public Firewall Firewall { get; set; }
        
        /// <summary>
        /// Toggles usage of ProfitBricks DHCP
        /// </summary>
        public bool DhcpActive { get; set; }

        /// <summary>
        /// IP address of gateway
        /// </summary>
        public string GatewayIp { get; set; }
    }
}

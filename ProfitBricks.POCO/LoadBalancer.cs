using ProfitBricks.POCO.Enums;
using System.Collections.Generic;

namespace ProfitBricks.POCO
{
    /// <summary>
    /// LoadBalancer
    /// </summary>
    public class LoadBalancer : ProfitBricksBase
    {
        /// <summary>
        /// Identifier of the load balancer
        /// </summary>
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// Outputs the name of the load balancer
        /// </summary>
        public string LoadBalancerName { get; set; }
        
        /// <summary>
        /// Outputs the load balancer algorithm. ROUND_ROBIN is the default and currently the only supported algorithm
        /// </summary>
        public LoadBalancerAlgorithm LoadBalancerAlgorithm { get; set; }

        /// <summary>
        /// Returns TRUE if load balancer is connected to a public LAN
        /// </summary>
        public bool InternetAccess { get; set; }

        /// <summary>
        /// IP address assigned to the load balancer
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// Identifier of the target LAN ID to which the load balancer and the balanced servers are connected
        /// </summary>
        public int LanId { get; set; }

        /// <summary>
        /// List all servers registered to the load balancer, including their identifier (serverId), name (serverName), identifier of the balanced Nic (balancedNicId) through which the load balancer forwards traffic to the server, and if load balancing is activate on this server (activate)
        /// </summary>
        public List<BalancedServer> BalancedServers { get; set; }
        
        /// <summary>
        /// Time when the specified virtual load balancer has been created
        /// </summary>
        public System.DateTime CreationTime { get; set; }

        /// <summary>
        /// Time when the specified virtual load balancer has last been modified
        /// </summary>
        public System.DateTime LastModificationTime { get; set; }

        /// <summary>
        /// Firewall created on the load balancer.
        /// </summary>
        public Firewall Firewall { get; set; }
    }
}

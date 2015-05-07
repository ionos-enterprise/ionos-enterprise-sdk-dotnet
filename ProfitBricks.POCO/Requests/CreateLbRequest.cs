using ProfitBricks.POCO.Enums;
using System.Collections.Generic;

namespace ProfitBricks.POCO.Requests
{
    /// <summary>
    /// CreateLbRequest
    /// </summary>
    public class CreateLbRequest : ProfitBricksBase
    {
        /// <summary>
        /// data center ID wherein the load balancer is to be created
        /// </summary>
        public string DataCenterId { get; set; }

        /// <summary>
        /// Name of the load balancer to be created
        /// </summary>
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// load balancer algorithm. ROUND_ROBIN is default and the only supported algorithm at the moment
        /// </summary>
        public LoadBalancerAlgorithm LoadBalancerAlgorithm { get; set; }

        /// <summary>
        /// A DHCP IP address is being assigned to the load balancer automatically by ProfitBricks. A private IP can be defined by the user. Additional, public IPs can be reserved and assigned to the load balancer manually.
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// Identifier of the target LAN ID > 0
        /// If the specified LAN ID does not exist or if LAN ID is not specified, a new LAN with the given ID / with a next available ID starting from 1 will be created respectively
        /// </summary>
        public int LanId { get; set; }

        /// <summary>
        /// Identifier of all servers, to which the load balancer is going to distribute traffic. Servers can also be registered to load balancer later 
        /// </summary>
        public List<string> ServerIds { get; set; }
    }
}

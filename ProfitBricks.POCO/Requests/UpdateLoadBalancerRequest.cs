using ProfitBricks.POCO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProfitBricks.POCO.Requests
{
    public class UpdateLoadBalancerRequest : ProfitBricksBase
    {
        /// <summary>
        /// The unique ID of the load balancer.	(Required field)
        /// </summary>
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The new name for the load balancer.	
        /// </summary>
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// Change the load balancer algorithm.	
        /// </summary>
        public LoadBalancerAlgorithm LoadBalancerAlgorithm { get; set; }

        /// <summary>
        /// Updates the IP address of the load balancer with the new IP. All connected servers will have their primary address updated with the same IP.
        /// </summary>
        public string Ip { get; set; }
    }
}

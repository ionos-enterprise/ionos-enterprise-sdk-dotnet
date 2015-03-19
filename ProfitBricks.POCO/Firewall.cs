using System.Collections.Generic;

namespace ProfitBricks.POCO
{
    /// <summary>
    /// Firewall
    /// </summary>
    public class Firewall : ProfitBricksBase
    {
        /// <summary>
        /// Firewall is active [TRUE/FALSE]
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Identifier of the target firewall
        /// </summary>
        public string FirewallId { get; set; }

        /// <summary>
        /// List all firewall rules, including their identifier (firewallRuleId), protocol, sourceMac, sourceIp, targetIp, portRangeStart, portRangeEnd, icmpType, and icmpCode
        /// </summary>
        public List<FirewallRule> FirewallRules { get; set; }

        /// <summary>
        /// Identifier of the target NIC
        /// </summary>
        public string NicId { get; set; }
    }
}

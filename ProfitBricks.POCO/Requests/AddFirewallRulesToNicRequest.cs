using System.Collections.Generic;

namespace ProfitBricks.POCO.Requests
{
    /// <summary>
    /// AddFirewallRulesToNicRequest
    /// </summary>
    public class AddFirewallRulesToNicRequest : ProfitBricksBase
    {
        /// <summary>
        /// Defines a set of accept-rules applied for the target NIC. 
        /// </summary>
        public List<FirewallRuleRequest> Request { get; set; }

        /// <summary>
        /// Identifier of target NIC
        /// </summary>
        public string NicId { get; set; }
    }
}

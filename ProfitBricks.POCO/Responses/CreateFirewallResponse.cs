using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProfitBricks.POCO.Responses
{
    public class CreateFirewallResponse : ResponseBase
    {
        public string NicId { get; set; }

        public bool Active { get; set; }

        public List<FirewallRule> FirewallRules { get; set; }
    }
}

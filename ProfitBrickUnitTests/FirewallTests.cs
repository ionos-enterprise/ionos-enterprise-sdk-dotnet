using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProfitBricks.Client;
using ProfitBricks.Client.Resources;
using ProfitBricks.POCO;
using ProfitBricks.POCO.Enums;
using ProfitBricks.POCO.Requests;
using ProfitBricks.POCO.Responses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProfitBrickUnitTests
{
    [TestClass]
    public class FirewallTests
    {
        private static string nicId;
        private static string firewallId;
        private static string firewallRuleId;

        Firewalls firewallApi = ProfitBricksSoapClient.Instance.Firewalls;

        #region Firewalls
        [ClassInitialize()]
        public static void Initialize(TestContext testContext)
        {
            var nics = ProfitBricksSoapClient.Instance.Nics.Get();

            Assert.IsNotNull(nics, "At least one NIC is required to run Firewall tests");

            nicId = nics.FirstOrDefault().NicId;
        }

        [TestMethod]
        public void AddFirewallRulesToNic()
        {
            var request = new AddFirewallRulesToNicRequest
            {
                NicId = nicId,
                Request = new System.Collections.Generic.List<FirewallRuleRequest>{
                    new FirewallRuleRequest
                    {
                        Protocol = ProfitBricks.POCO.Enums.Protocol.ANY,
                        PortRangeEnd = 22222,
                        PortRangeStart = 44444,
                        IcmpCode = 222,
                        IcmpType = 222,
                        Name = "name"
                    }
                }
            };

            var response = firewallApi.Create(request);
            
            Assert.IsNotNull(response);
            firewallId = response.Id;
        }

        [TestMethod]
        public void GetAllFirewalls()
        {
            var firewalls = firewallApi.Get();

            Assert.IsNotNull(firewalls);
        }
     
        [TestMethod]
        public void GetOneFirewall()
        {
            var firewall = firewallApi.Show(firewallId);

            Assert.IsNotNull(firewall);

            firewallRuleId = firewall.FirewallRules.FirstOrDefault().FirewallRuleId;
        }

        [TestMethod]
        public void ActivateFirewall()
        {
            firewallApi.Activate(new List<string> { firewallId });
        }

        [TestMethod]
        public void DeactivateFirewall()
        {
            firewallApi.Deactivate(new List<string> { firewallId });
        }

        [TestMethod]
        public void RemoveFirewall()
        {
            firewallApi.RemoveFirewallRules(new List<string> { firewallRuleId });
        }


        [TestMethod]
        public void DeleteFirewall()
        {
            firewallApi.Delete(firewallId);
        }

        #endregion
    }
}

using ProfitBricks.Client.Helper;
using ProfitBricks.Client.ProfitBricksProxy;
using ProfitBricks.POCO;
using ProfitBricks.POCO.Requests;
using ProfitBricks.POCO.Responses;
using System;
using System.Collections.Generic;

namespace ProfitBricks.Client.Resources
{
    /// <summary>
    /// Firewalls service class
    /// </summary>
    public class Firewalls : SoapService<Firewall>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="client">Proxy class instance</param>
        public Firewalls(ProfitbricksApiServicePortTypeClient client) : base(client) { }

        /// <summary>
        /// Returns initialized instance of AddFirewallRulesToNicRequest
        /// </summary>
        /// <returns>POCO.AddFirewallRulesToNicRequest</returns>
        public override ResponseBase Create(ProfitBricksBase request)
        {
            var copy = new addFirewallRulesToNicRequest();
            var original = request as AddFirewallRulesToNicRequest;
            copy.nicId = original.NicId;
            copy.request = new firewallRuleRequest[original.Request.Count];

            for (var i = 0; i < original.Request.Count; i++)
            {
                copy.request[i] = new firewallRuleRequest
                {
                    icmpCode = original.Request[0].IcmpCode,
                    icmpType = original.Request[0].IcmpType,
                    name = original.Request[0].Name,
                    portRangeEnd = original.Request[0].PortRangeEnd,
                    portRangeStart = original.Request[0].PortRangeStart,
                    protocol = (protocol)original.Request[0].Protocol,
                    sourceIp = original.Request[0].SourceIp,
                    sourceMac = original.Request[0].SourceMac,
                    targetIp = original.Request[0].TargetIp
                };
            }

            var response = Client.addFirewallRulesToNic(copy.request, copy.nicId);
            var toReturn = new CreateFirewallResponse { Id = response.firewallId, NicId = response.nicId, Active = response.active };
            toReturn.FirewallRules = Converters.ConvertFirewallRules(response.firewallRules);

            return toReturn;
        }

        /// <summary>
        /// Returns information about all configured firewall. Each rule has an identifier for later modification. 
        /// </summary>
        /// <returns></returns>
        public override List<Firewall> Get()
        {
            var firewalls = Client.getAllFirewalls();
            var toReturn = new List<Firewall>();

            foreach (var firewall in firewalls)
            {
                toReturn.Add(Converters.ConvertFirewall(firewall));
            }

            return toReturn;
        }

        /// <summary>
        /// Returns information about the state and configuration of an existing NIC.
        /// </summary>
        /// <param name="id">Identifier of the target NIC</param>
        /// <returns>Instgance of POCO.FireWall</returns>
        public override Firewall Show(string id)
        {
            return Converters.ConvertFirewall(Client.getFirewall(id));
        }

        /// <summary>
        /// Not Supported
        /// </summary>
        /// <param name="obj"></param>
        public override void Update(POCO.ProfitBricksBase obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes one firewall of a given data center.
        /// </summary>
        /// <param name="id">Identifier of the target firewall</param>
        public override void Delete(string id)
        {
            Client.deleteFirewalls(new string[] { id });
        }

        /// <summary>
        /// Deletes one or several firewall(s) of a given data center.
        /// </summary>
        /// <param name="ids">Identifier(s) of the target firewall(s)</param>
        public void DeleteMany(List<string> ids)
        {
            Client.deleteFirewalls(ids.ToArray());
        }

        /// <summary>
        /// Activates one or several firewall(s) of a given data center.
        /// </summary>
        /// <param name="ids">Identifier(s) of the target firewall(s)</param>
        public void Activate(List<string> ids)
        {
            Client.activateFirewalls(ids.ToArray());
        }

        /// <summary>
        /// Deactivates one or several firewall(s) of a given data center.
        /// </summary>
        /// <param name="ids">Identifier(s) of the target firewall(s)</param>
        public void Deactivate(List<string> ids)
        {
            Client.deactivateFirewalls(ids.ToArray());
        }

        /// <summary>
        /// Removes firewall rule(s) by specifying their identifiers. See also getFirewall() or getNic() to retrieve identifiers of firewall rules.
        /// </summary>
        /// <param name="ids">Identifiers of the target firewall rules</param>
        public void RemoveFirewallRules(List<string> ids)
        {
            Client.removeFirewallRules(ids.ToArray());
        }
    }
}

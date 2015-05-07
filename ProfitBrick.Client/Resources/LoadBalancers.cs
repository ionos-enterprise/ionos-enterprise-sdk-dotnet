using ProfitBricks.Client.Helper;
using ProfitBricks.Client.ProfitBricksProxy;
using ProfitBricks.POCO;
using ProfitBricks.POCO.Extensions;
using ProfitBricks.POCO.Responses;
using System;
using System.Collections.Generic;

namespace ProfitBricks.Client.Resources
{
    /// <summary>
    /// LoadBalancers service class.
    /// </summary>
    public class LoadBalancers : SoapService<LoadBalancer>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="client">Proxy class instance</param>
        public LoadBalancers(ProfitbricksApiServicePortTypeClient client) : base(client) { }

        /// <summary>
        /// Returns initialized instance of Volume
        /// </summary>
        /// <returns>POCO.CreateLbRequest</returns>
        public override ResponseBase Create(ProfitBricksBase request)
        {
            var response = Client.createLoadBalancer(request.Cast<createLbRequest>());

            return new CreateLoadBalancerResponse { Id = response.loadBalancerId, DataCenterId = response.dataCenterId, DataCenterVersion = response.dataCenterVersion, RequestId = response.requestId };
        }

        /// <summary>
        /// Returns information about all virtual load balancer.
        /// </summary>
        /// <returns></returns>
        /// <returns>Generic list of POCO.ProfitBricksBase objects</returns>
        public override List<LoadBalancer> Get()
        {
            var toReturn = new List<LoadBalancer>();

            var loadBalancers = Client.getAllLoadBalancers();

            if (loadBalancers != null)
                foreach (var loadBalancer in loadBalancers)
                {
                    toReturn.Add(Converters.ConvertLoadBalancer(loadBalancer));
                }

            return toReturn;
        }

        /// <summary>
        /// Fetches a single object 
        /// </summary>
        /// <param name="id">Volume identifier</param>
        /// <returns>Instance of POCO.LoadBalancer</returns>
        public override LoadBalancer Show(string id)
        {
            return Converters.ConvertLoadBalancer(Client.getLoadBalancer(id));
        }

        /// <summary>
        /// Changes the settings of an existing virtual load balancer.
        /// </summary>
        /// <param name="obj">LoadBalancer to be updated.</param>
        public override void Update(POCO.ProfitBricksBase obj)
        {
            Client.updateLoadBalancer(obj.Cast<updateLbRequest>());
        }

        /// <summary>
        /// Deletes an existing load balancer.  Primary IP addresses of the server’s previously balanced NICs are reset and replaced with ProfitBricks assigned IP address. If a load balancer has been deleted, all servers will still be connected to the same LAN though.
        /// </summary>
        /// <param name="id">Identifier of target load balancer</param>
        public override void Delete(string id)
        {
            Client.deleteLoadBalancer(id);
        }

        /// <summary>
        /// Adds new servers to an existing Load Balancer within the respective LAN. If the server is not yet a member of the LAN, a new NIC is created, connected to the LAN and registered with the Load Balancer. The load balancer will distribute traffic to the server through this balanced NIC. If the server is already a member of the LAN, the appropriate NIC is used as balanced NIC. A server can be registered to more than one Load Balancer.
        /// </summary>
        /// <param name="loadBalancerId">Identifier of target load balancer</param>
        /// <param name="serverIds">Identifier of servers to be registered with target load balancer</param>
        public void RegisterServer(string loadBalancerId, List<string> serverIds)
        {
            Client.registerServersOnLoadBalancer(serverIds.ToArray(), loadBalancerId);
        }

        /// <summary>
        /// By deregistering a server,  the server is being removed from the load balancer but still remains connected to the same LAN. The primary IP address of the NIC, through which the load balancer distributed traffic to the server before, is reset and replaced by a ProfitBricks assigned IP address.
        /// </summary>
        /// <param name="loadBalancerId">Identifier of target load balancer</param>
        /// <param name="serverIds">Identifier of servers to be registered with target load balancer</param>
        public void UnregisterServer(string loadBalancerId, List<string> serverIds)
        {
            Client.deregisterServersOnLoadBalancer(serverIds.ToArray(), loadBalancerId);
        }

        /// <summary>
        /// This feature is not supported any longer. It is not possible to activate or deactivate load balancing on servers.
        ///In case you enable or disable servers from load balancing please use the following methods:
        /// </summary>
        /// <param name="loadBalancerId"></param>
        /// <param name="serverIds"></param>
        [Obsolete]
        public void ActivateLoadBalancer(string loadBalancerId, List<string> serverIds)
        {
            Client.activateLoadBalancingOnServers(loadBalancerId, serverIds.ToArray());
        }
    }
}

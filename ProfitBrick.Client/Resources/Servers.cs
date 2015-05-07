using ProfitBricks.Client.Helper;
using ProfitBricks.Client.ProfitBricksProxy;
using ProfitBricks.POCO;
using ProfitBricks.POCO.Enums;
using ProfitBricks.POCO.Extensions;
using ProfitBricks.POCO.Responses;
using System.Collections.Generic;
using System.Linq;

namespace ProfitBricks.Client.Resources
{
    /// <summary>
    /// Servers service class.
    /// </summary>
    public class Servers : SoapService<Server>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="client">Proxy class instance</param>
        public Servers(ProfitbricksApiServicePortTypeClient client) : base(client) { }

        /// <summary>
        /// Returns initialized instance of CreateServerRequest
        /// </summary>
        /// <returns>POCO.CreateServerRequest</returns>
        public override ResponseBase Create(ProfitBricksBase request)
        {
            var response = Client.createServer(request.Cast<createServerRequest>());

            return new CreateServerResponse { Id = response.serverId, DataCenterId = response.dataCenterId, DataCenterVersion = response.dataCenterVersion, RequestId = response.requestId };
        }

        /// <summary>
        /// Fetches list of all Servers.
        /// </summary>
        /// <returns>Generic list of POCO.ProfitBricksBase objects</returns>
        public override List<Server> Get()
        {
            var svrs = Client.getAllServers();
            var toReturn = new List<Server>();

            if (svrs != null)
            {
                foreach (var svr in svrs)
                {
                    toReturn.Add(Converters.ConvertServer(svr));
                }
            }
            return toReturn;
        }

        /// <summary>
        /// Fetches a single object 
        /// </summary>
        /// <param name="serverId">Server identifier</param>
        /// <returns>Instance of POCO.Server</returns>
        public override Server Show(string serverId)
        {
            var svr = Client.getServer(serverId);
            var toReturn = new Server
            {
                ServerId = svr.serverId,
                ServerName = svr.serverName,
                Cores = svr.cores,
                Ram = svr.ram,
                InternetAccess = svr.internetAccess,
                Ips = svr.ips == null ? new List<string>() : svr.ips.ToList(),
                CreationTime = svr.creationTime,
                LastModificationTime = svr.lastModificationTime,
                OsType = (OsType)svr.osType,
                AvailabilityZone = (AvailabilityZone)svr.availabilityZone,
                CpuHotPlug = svr.cpuHotPlug,
                RamHotPlug = svr.ramHotPlug,
                NicHotPlug = svr.nicHotPlug,
                NicHotUnPlug = svr.nicHotUnPlug,
                DiscVirtioHotPlug = svr.discVirtioHotPlug,
                DiscVirtioHotUnPlug = svr.discVirtioHotUnPlug
            };

            toReturn.Nics = new List<Nic>();

            if (svr.nics != null)
            {
                foreach (var nic in svr.nics)
                {
                    toReturn.Nics.Add(Converters.ConvertNic(nic));
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Updates an instance of Server.
        /// </summary>
        /// <param name="obj">Server to be updated</param>
        public override void Update(ProfitBricksBase obj)
        {
            Client.updateServer(obj.Cast<updateServerRequest>());
        }

        /// <summary>
        /// Deletes an existing Virtual Server.
        /// </summary>
        /// <param name="serverId">Identifier of the target virtual server</param>
        public override void Delete(string serverId)
        {
            Client.deleteServer(serverId);
        }

        /// <summary>
        /// Resets an existing virtual server (POWER CYCLE).
        /// - Server will be forcefully powered off and restarted immediately. Any unsaved data may be lost!
        /// - Billing will continue
        /// </summary>
        /// <param name="serverId"></param>
        public void ResetServer(string serverId)
        {
            Client.resetServer(serverId);
        }

        /// <summary>
        /// Starts an existing virtual server
        /// - Server may receive new public IP addresses if necessary
        /// - Billing will continue
        /// </summary>
        /// <param name="serverId"></param>
        public void StartServer(string serverId)
        {
            Client.startServer(serverId);
        }

        /// <summary>
        /// Stops an existing virtual server forcefully (HARD stop)
        /// - Server will be forcefully powered off. Any unsaved data may be lost!
        /// - Billing for this server will be stopped
        /// - When restarting the server a new public IP gets assigned, alternatively, you can reserve IP addresses,
        /// </summary>
        /// <param name="serverId"></param>
        public void StopServer(string serverId)
        {
            Client.stopServer(serverId);
        }
    }
}
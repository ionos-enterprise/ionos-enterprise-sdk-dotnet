using ProfitBricks.Client.Helper;
using ProfitBricks.Client.ProfitBricksProxy;
using ProfitBricks.POCO;
using ProfitBricks.POCO.Enums;
using ProfitBricks.POCO.Extensions;
using ProfitBricks.POCO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ProfitBricks.Client.Resources
{
    /// <summary>
    /// PublicIpBlocks service class.
    /// </summary>
    public class PublicIpBlocks : SoapService<IpBlock>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="client">Proxy class instance</param>
        public PublicIpBlocks(ProfitbricksApiServicePortTypeClient client) : base(client) { }

        /// <summary>
        /// Returns initialized instance of CreateReservePublicIpBlockRequest
        /// </summary>
        /// <returns>POCO.CreateReservePublicIpBlockRequest</returns>
        public override ResponseBase Create(ProfitBricksBase request)
        {
            var response = Client.reservePublicIpBlock(request.Cast<createReservePublicIpBlockRequest>());

            var toReturn = new IpBlockResponse { Id = response.blockId, Location = (Location)response.location, };
            toReturn.Ips = response.ips == null ? new List<string>() : response.ips.ToList();

            return toReturn;
        }

        /// <summary>
        /// Fetches list of all PublicIbBlocks
        /// </summary>
        /// <returns>Generic list of POCO.ProfitBricksBase objects</returns>
        public override List<IpBlock> Get()
        {
            var ips = Client.getAllPublicIpBlocks();
            var toReturn = new List<IpBlock>();
            foreach (var ip in ips)
            {
                toReturn.Add(Converters.ConvertIp(ip));
            }

            return toReturn;
        }

        /// <summary>
        /// Fetches a single object 
        /// </summary>
        /// <param name="id">PublicIpBlock identifier</param>
        /// <returns>Instance of POCO.PublicIpBlock</returns>
        public override IpBlock Show(string id)
        {
            return Converters.ConvertIp(Client.getPublicIpBlock(id));
        }

        /// <summary>
        /// Removes a reserved public IP from a NIC. This operation is required, when dealing with reserved public IPs to ensure proper routing by the ProfitBricks cloud networking layer.
        /// </summary>
        /// <param name="ip">IP address</param>
        /// <param name="nicId">Identifier of the target NIC</param>
        public void Delete(string ip, string nicId)
        {
            Client.removePublicIpFromNic(ip, nicId);
        }

        /// <summary>
        /// Releases an existing block of reserved public IPs.
        /// </summary>
        /// <param name="blockId">Identifier of the reserved IP block</param>
        public void ReleasePublicIpBlock(string blockId)
        {
            Client.releasePublicIpBlock(blockId);
        }

        /// <summary>
        /// Assign an existing reserved public IP to a NIC. This must happen before the IP can be routed correctly.
        /// </summary>
        public void AddPublicIpToNic(string ip, string nicId)
        {
            Client.addPublicIpToNic(ip, nicId);
        }

        /// <summary>
        /// Remove a public IP from the specified NIC.
        /// </summary>
        public void RemovePublicIpFromNic(string ip, string nicId)
        {
            Client.removePublicIpFromNic(ip, nicId);
        }

        #region Not supported

        /// <summary>
        /// Not supported
        /// </summary>
        /// <param name="obj"></param>
        public override void Update(POCO.ProfitBricksBase obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Not supported
        /// </summary>
        /// <param name="id"></param>
        public override void Delete(string id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

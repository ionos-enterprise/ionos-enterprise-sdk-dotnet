using ProfitBricks.Client.Helper;
using ProfitBricks.Client.ProfitBricksProxy;
using ProfitBricks.POCO;
using ProfitBricks.POCO.Extensions;
using ProfitBricks.POCO.Responses;
using System.Collections.Generic;

namespace ProfitBricks.Client.Resources
{
    /// <summary>
    /// Nics service class
    /// </summary>
    public class Nics : SoapService<Nic>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="client">Proxy class instance</param>
        public Nics(ProfitbricksApiServicePortTypeClient client) : base(client) { }

        /// <summary>
        /// Returns initialized instance of CreateNicRequest
        /// </summary>
        /// <returns>POCO.CreateNicRequest</returns>
        public override ResponseBase Create(ProfitBricksBase request)
        {
            var response = Client.createNic(request.Cast<createNicRequest>());

            return new CreateNicResponse { Id = response.nicId, RequestId = response.requestId, DataCenterId = response.dataCenterId, DataCenterVersion = response.dataCenterVersion };
        }

        /// <summary>
        /// Fetches list of all Nics.
        /// </summary>
        /// <returns>Generic list of POCO.Nic objects</returns>
        public override List<Nic> Get()
        {
            var toReturn = new List<Nic>();

            var nics = Client.getAllNic();

            foreach (var nic in nics)
            {
                toReturn.Add(Converters.ConvertNic(nic));
            }

            return toReturn;
        }

        /// <summary>
        /// Fetches a single object 
        /// </summary>
        /// <param name="id">Nic identifier</param>
        /// <returns>Instance of POCO.Nic</returns>
        public override Nic Show(string id)
        {
            return Converters.ConvertNic(Client.getNic(id));
        }

        /// <summary>
        /// Changes the settings of an existing NIC.
        /// </summary>
        /// <param name="obj">Nic to be updated.</param>
        public override void Update(POCO.ProfitBricksBase obj)
        {
            Client.updateNic(obj.Cast<updateNicRequest>());
        }

        /// <summary>
        /// Deletes an existing NIC.
        /// </summary>
        /// <param name="id">Identifier of the target NIC</param>
        public override void Delete(string id)
        {
            Client.deleteNic(id);
        }

        /// <summary>
        /// Connects an existing NIC to a public LAN to get internet access.
        /// </summary>
        /// <param name="dataCenterId">Identifier of the target data center</param>
        /// <param name="lanId">Identifier of the target LAN</param>
        /// <param name="internetAccess">Internet access (TRUE/FALSE)</param>
        public void SetInternetAccess(string dataCenterId, int lanId, bool internetAccess)
        {
            Client.setInternetAccess(dataCenterId, lanId, internetAccess);
        }
    }
}

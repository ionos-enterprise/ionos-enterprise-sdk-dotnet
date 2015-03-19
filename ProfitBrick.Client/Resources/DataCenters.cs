using ProfitBricks.Client.Helper;
using ProfitBricks.Client.ProfitBricksProxy;
using ProfitBricks.POCO;
using ProfitBricks.POCO.Enums;
using ProfitBricks.POCO.Extensions;
using ProfitBricks.POCO.Responses;
using System.Collections.Generic;

namespace ProfitBricks.Client.Resources
{
    /// <summary>
    /// DataCenters service class
    /// </summary>
    public class DataCenters : SoapService<DataCenter>
    {
        /// <summary>
        /// Constructor
        /// </summary>        
        /// <param name="client">Proxy class instance</param>
        public DataCenters(ProfitbricksApiServicePortTypeClient client) : base(client) { }

        /// <summary>
        /// Returns initialized instance of CreateDataCenterRequest
        /// </summary>
        /// <returns>POCO.CreateDataCenterRequest</returns>
        public override ResponseBase Create(ProfitBricksBase request)
        {
            var response  = Client.createDataCenter(request.Cast<createDataCenterRequest>());

            return new CreateDataCenterResponse { Id = response.dataCenterId, DataCenterVersion = response.dataCenterVersion, Location = (Location)response.location, RequestId = response.requestId };
        }

        /// <summary>
        /// Fetches list of all DataCenters
        /// </summary>        
        /// <returns>Generic list of POCO.ProfitBricksBase objects</returns>
        public override List<DataCenter> Get()
        {
            var dcs = Client.getAllDataCenters();

            var toReturn = new List<DataCenter>();
            if (dcs != null)
            {
                foreach (var dc in dcs)
                {
                    toReturn.Add(this.Show(dc.dataCenterId));
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Fetches a single object 
        /// </summary>
        /// <param name="dataCenterId">DataCenter identifier</param>
        /// <returns>Instance of POCO.DataCenter</returns>
        public override DataCenter Show(string dataCenterId)
        {
            var dc = Client.getDataCenter(dataCenterId);

            return Converters.ConvertDataCenter(dc);
        }

        /// <summary>
        /// Updates an instance of DataCenter.
        /// </summary>
        /// <param name="obj">DataCenter to be updated</param>
        public override void Update(POCO.ProfitBricksBase obj)
        {
            Client.updateDataCenter(obj.Cast<updateDcRequest>());
        }

        /// <summary>
        /// Deletes an Virtual Data Center. If a previous request on the target data center is still in progress, the data center is going to be deleted after this request has been completed. Once a Data Center has been deleted, no further request can be performed on it.
        /// </summary>
        /// <param name="dataCenterId">Identifier of the virtual data center</param>
        public override void Delete(string dataCenterId)
        {
            Client.deleteDataCenter(dataCenterId);
        }

        /// <summary>
        /// This is a lightweight function for pooling the current provisioning state of the Virtual Data Center. It is recommended to use this function for large Virtual Data Centers to query request results.
        /// </summary>
        /// <param name="dataCenterId"></param>
        /// <returns></returns>
        public ProvisioningState GetDataCenterState(string dataCenterId)
        {
            return (ProvisioningState)Client.getDataCenterState(dataCenterId);
        }

        /// <summary>
        /// Removes all components from an existing Virtual Data Center.
        /// </summary>
        /// <param name="dataCenterId">Identifier of the virtual data center</param>
        public void ClearDataCenter(string dataCenterId)
        {
            Client.clearDataCenter(dataCenterId);
        }
    }
}
using ProfitBricks.Client.Helper;
using ProfitBricks.Client.ProfitBricksProxy;
using ProfitBricks.POCO;
using ProfitBricks.POCO.Extensions;
using ProfitBricks.POCO.Requests;
using ProfitBricks.POCO.Responses;
using System.Collections.Generic;

namespace ProfitBricks.Client.Resources
{
    /// <summary>
    /// Volumes service class.
    /// </summary>
    public class Volumes : SoapService<Volume>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="client">Proxy class instance</param>
        public Volumes(ProfitbricksApiServicePortTypeClient client) : base(client) { }

        /// <summary>
        /// Returns initialized instance of CreateStorageRequest
        /// </summary>
        /// <returns>POCO.CreateStorageRequest</returns>
        public override ResponseBase Create(ProfitBricksBase request)
        {
            var response = Client.createStorage(request.Cast<createStorageRequest>());
            
            return new CreateVolumeResponse { RequestId = response.requestId, Id = response.storageId };
        }

        /// <summary>
        /// Fetches list of all Volumes.
        /// </summary>
        /// <returns>Generic list of POCO.ProfitBricksBase objects</returns>
        public override List<Volume> Get()
        {
            var storages = Client.getAllStorages();
            var toReturn = new List<Volume>();

            if (storages != null)
            {
                foreach (var storage in storages)
                {
                    toReturn.Add(Converters.ConvertStorages(storage));
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Fetches a single object 
        /// </summary>
        /// <param name="volumeId">Volume identifier</param>
        /// <returns>Instance of POCO.Volume</returns>
        public override Volume Show(string volumeId)
        {
            return Converters.ConvertStorages(Client.getStorage(volumeId));
        }

        /// <summary>
        /// Updates an instance of Volume.
        /// </summary>
        /// <param name="obj">Volume to be updated</param>
        public override void Update(POCO.ProfitBricksBase obj)
        {
            Client.updateStorage(obj.Cast<updateStorageRequest>());
        }

        /// <summary>
        /// Deletes an existing virtual storage device.
        /// </summary>
        /// <param name="id">Identifier of the target virtual storage. Required field.</param>
        public override void Delete(string id)
        {
            Client.deleteStorage(id);
        }

        /// <summary>
        /// Connects a virtual storage device to an existing server.
        /// </summary>
        /// <param name="request">Request containing required parameters.</param>
        public void ConnectVolume(ConnectStorageRequest request)
        {
            Client.connectStorageToServer(request.Cast<connectStorageRequest>());
        }

        /// <summary>
        /// Disconnects a virtual storage device from a connected server.
        /// </summary>
        /// <param name="storageId">Identifier of the connected virtual storage</param>
        /// <param name="serverId">Identifier of the connected virtual server</param>
        public void DisconnectVolume(string storageId, string serverId)
        {
            Client.disconnectStorageFromServer(storageId, serverId);
        }
    }
}
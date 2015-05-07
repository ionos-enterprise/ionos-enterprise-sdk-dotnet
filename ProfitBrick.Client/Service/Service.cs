using ProfitBricks.Client.ProfitBricksProxy;
using ProfitBricks.POCO;
using ProfitBricks.POCO.Responses;
using System.Collections.Generic;

namespace ProfitBricks.Client
{
    /// <summary>
    /// Represents a base class for all resources. Containing basic server operations.
    /// </summary>
    public abstract class SoapService<T> where T : ProfitBricksBase
    {
        /// <summary>
        /// ProfitBricks Client instance
        /// </summary>
        public ProfitbricksApiServicePortTypeClient Client { get; set; }

        /// <summary>
        /// Creates an instance of request used to create Profixt Bricks objects.
        /// </summary>
        /// <returns>Returns an instance of create request.</returns>
        public abstract ResponseBase Create(ProfitBricksBase request);

        /// <summary>
        /// Gets all objects of the resource.
        /// </summary>
        /// <returns>List of ProfitBricksBase objects</returns>
        public abstract List<T> Get();

        /// <summary>
        /// Returns a single object of the resource
        /// </summary>
        /// <param name="id">Resource identifier</param>
        /// <returns>Instance of ProfitBricksBase</returns>
        public abstract T Show(string id);

        /// <summary>
        /// Updates object passed onto the resource passed on. 
        /// </summary>
        /// <param name="obj">Object to be updated</param>
        public abstract void Update(ProfitBricksBase obj);

        /// <summary>
        /// Deletes an instance of resource
        /// </summary>
        /// <param name="id">Resource identifier</param>
        public abstract void Delete(string id);

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="client">Client instance</param>
        public SoapService(ProfitbricksApiServicePortTypeClient client)
        {
            Client = client;
        }
    }
}
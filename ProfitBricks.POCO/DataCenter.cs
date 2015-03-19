using ProfitBricks.POCO.Enums;
using System.Collections.Generic;

namespace ProfitBricks.POCO
{
    /// <summary>
    /// Information about an existing virtual data center’s state and configuration.
    /// </summary>
    public class DataCenter : ProfitBricksBase
    {
        /// <summary>
        /// Identifier of the virtual data center
        /// </summary>
        public string DataCenterId { get; set; }

        /// <summary>
        /// Name of the new virtual data center
        /// </summary>
        public string DataCenterName { get; set; }

        /// <summary>
        /// Region where the data center has been created (NORTH_AMERICA, EUROPE)
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// A list of all virtual servers.
        /// </summary>
        public List<Server> Servers { get; set; }

        /// <summary>
        /// A list of all virtual storages. 
        /// </summary>
        public List<Volume> Volumes { get; set; }

        /// <summary>
        /// A list of all virtual load balancers.
        /// </summary>
        public List<LoadBalancer> LoadBalancers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int DataCenterVersion { get; set; }
    }
}

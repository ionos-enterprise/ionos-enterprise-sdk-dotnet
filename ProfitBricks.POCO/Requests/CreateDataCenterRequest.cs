using ProfitBricks.POCO.Enums;

namespace ProfitBricks.POCO.Requests
{
    /// <summary>
    /// CreateDataCenterRequest
    /// </summary>
    public class CreateDataCenterRequest : ProfitBricksBase
    {
        /// <summary>
        /// Names the new virtual data center. If no name is specified, the data center will be named “Unnamed Data Center” by default.
        /// </summary>
        public string DataCenterName { get; set; }

        /// <summary>
        /// Select region to create the data center (NORTH_AMERICA, EUROPE, DEFAULT).
        /// If set to DEFAULT or left empty, data center will be created in the default region of the customer
        /// </summary>
        public Location Location { get; set; }
    }
}


namespace ProfitBricks.POCO.Requests
{
    /// <summary>
    /// UpdateDataCenterRequest
    /// </summary>
    public class UpdateDataCenterRequest : ProfitBricksBase
    {
        /// <summary>
        /// Identifier of the virtual data center. Required Field.
        /// </summary>
        public string DataCenterId { get; set; }

        /// <summary>
        /// Renames the target virtual data center
        /// </summary>
        public string DataCenterName { get; set; }
    }
}

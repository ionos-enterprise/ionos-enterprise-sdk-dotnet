
namespace ProfitBricks.POCO
{
    /// <summary>
    /// Balanced server class.
    /// </summary>
    public class BalancedServer : ProfitBricksBase
    {
        /// <summary>
        /// Activate
        /// </summary>
        public bool Activate { get; set; }

        /// <summary>
        /// BlancedNicId
        /// </summary>
        public string BlancedNicId { get; set; }

        /// <summary>
        /// ServerId
        /// </summary>
        public string ServerId { get; set; }

        /// <summary>
        /// ServerName
        /// </summary>
        public string ServerName { get; set; }
    }
}

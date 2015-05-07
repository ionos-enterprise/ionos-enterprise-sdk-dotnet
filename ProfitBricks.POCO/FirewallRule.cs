using ProfitBricks.POCO.Enums;

namespace ProfitBricks.POCO
{
    /// <summary>
    /// 
    /// </summary>
    public class FirewallRule : ProfitBricksBase
    {
        
        public string FirewallRuleId { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int IcmpCode { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int IcmpType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int PortRangeEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int PortRangeStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Protocol Protocol { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SourceIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SourceMac { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TargetIp { get; set; }
    }
}

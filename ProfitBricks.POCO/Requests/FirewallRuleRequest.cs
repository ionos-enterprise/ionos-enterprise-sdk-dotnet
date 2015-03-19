using ProfitBricks.POCO.Enums;

namespace ProfitBricks.POCO.Requests
{
    /// <summary>
    /// Firewall Rule
    /// </summary>
    public class FirewallRuleRequest : ProfitBricksBase
    {
        /// <summary>
        /// Defines the allowed code (from 0 to 254) if protocol ICMP is chosen. Leave empty to allow all types
        /// </summary>
        public int IcmpCode { get; set; }

        /// <summary>
        /// Defines the allowed type (from 0 to 254) if protocol ICMP is chosen. Leave empty to allow all types
        /// </summary>
        public int IcmpType { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Defines the end range of the allowed port (from 1 to 65534) if protocol TCP or UDP is chosen. Leave portRangeStart and portRangeEnd empty to allow all ports
        /// </summary>
        public int PortRangeEnd { get; set; }

        /// <summary>
        /// Defines the start range of the allowed port (from 1 to 65534) if protocol TCP or UDP is chosen. Leave portRangeStart and portRangeEnd empty to allow all ports
        /// </summary>
        public int PortRangeStart { get; set; }

        /// <summary>
        /// Select allowed protocol (TCP, UPD, ICMP, ANY). Default is ANY
        /// </summary>
        public Protocol Protocol { get; set; }

        /// <summary>
        /// Only traffic originated from the respective IPv4 address is allowed. Leave empty to allow all source IPs
        /// </summary>
        public string SourceIp { get; set; }

        /// <summary>
        /// SourceMac
        /// </summary>
        public string SourceMac { get; set; }

        /// <summary>
        /// In case the target NIC has multiple IP addresses, only traffic directed to the respective IP address of the NIC is allowed. Left empty to allow all target IPs
        /// </summary>
        public string TargetIp { get; set; }
    }
}

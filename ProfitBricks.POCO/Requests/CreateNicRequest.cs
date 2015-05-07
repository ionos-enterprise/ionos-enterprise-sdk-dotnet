
namespace ProfitBricks.POCO.Requests
{
    /// <summary>
    /// CreateNicRequest
    /// </summary>
    public class CreateNicRequest : ProfitBricksBase
    {
        /// <summary>
        /// Identifier of the target virtual server. Required field.
        /// </summary>
        public string ServerId { get; set; }

        /// <summary>
        /// Identifier of the target LAN > 0 that is to be connected to the specified virtual server. If no LAN exists for such ID, a new LAN with the given ID will be created.
        /// </summary>
        public int LanId { get; set; }

        /// <summary>
        /// Names the NIC
        /// </summary>
        public string NicName { get; set; }

        /// <summary>
        /// Public/private IP address. 
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// Toggles usage of ProfitBricks DHCP
        /// </summary>
        public bool DhcpActive { get; set; }
    }
}

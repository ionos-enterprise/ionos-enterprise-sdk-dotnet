
namespace ProfitBricks.POCO
{
    /// <summary>
    /// PublicIpBlock
    /// </summary>
   public class PublicIpBlock
    {
       /// <summary>
        /// Identifier of the IP block
       /// </summary>
       public string Ip { get; set; }

       /// <summary>
       /// Identifier of the target NIC
       /// </summary>
       public string NicId { get; set; }
    }
}

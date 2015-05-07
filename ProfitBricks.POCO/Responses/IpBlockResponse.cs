using System.Collections.Generic;

namespace ProfitBricks.POCO.Responses
{
    public class IpBlockResponse : ResponseBase
    {
        public Enums.Location Location { get; set; }

        public List<string> Ips { get; set; }
    }
}


namespace ProfitBricks.POCO.Responses
{
    public abstract class ResponseBase
    {
        public string Id { get; set; }
        public string RequestId { get; set; }
        public string DataCenterId { get; set; }
        public int DataCenterVersion { get; set; }
    }
}

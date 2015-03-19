using ProfitBricks.POCO.Enums;

namespace ProfitBricks.POCO
{
    /// <summary>
    /// Notification
    /// </summary>
    public class Notification : ProfitBricksBase
    {
        /// <summary>
        /// Identifier of the this notification
        /// </summary>
        public string Id { get; set; }
        
        /// <summary>
        /// Uuid of the network the notification refers to
        /// </summary>
        public string NetworkUUid { get; set; }

        /// <summary>
        /// Id of specific component of type 'relatedItemType' that the message concerns
        /// </summary>
        public string RelatedItemUuid { get; set; }

        /// <summary>
        /// Creation time of this notification
        /// </summary>
        public System.DateTime Timestamp { get; set; }

        /// <summary>
        /// One of 'MessageCodes'
        /// </summary>
        public NotificationCode MessageCode { get; set; }

        /// <summary>
        /// One of 'ItemTypes'
        /// </summary>
        public VirtualItemType RelatedItemType { get; set; }

        /// <summary>
        /// Textual message
        /// </summary>
        public string Message { get; set; }
    }
}

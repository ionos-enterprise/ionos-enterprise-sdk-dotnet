using ProfitBricks.Client.Helper;
using ProfitBricks.Client.ProfitBricksProxy;
using ProfitBricks.POCO;
using System.Collections.Generic;

namespace ProfitBricks.Client.Resources
{
    /// <summary>
    /// UserNotifications service class
    /// </summary>
    public class UserNotifications
    {
        /// <summary>
        /// ProfitBricks Client instance
        /// </summary>
        public ProfitbricksApiServicePortTypeClient Client { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="client">Proxy class instance</param>
        public UserNotifications(ProfitbricksApiServicePortTypeClient client)
        {
            Client = client;
        }

        /// <summary>
        /// Gets all current (not deleted) user notifications.
        /// User notifications are created by the system to inform users about different events concerning e.g. their data centers. Notifications stay in the queue until deleted.
        /// </summary>
        /// <param name="networkUUID">Uuid of the network the notification refers to</param>
        /// <returns>List of UserNotifications.</returns>
        public List<Notification> Get(string networkUUID)
        {
            var toReturn = new List<Notification>();

            var notifications = Client.getNotifications(networkUUID);

            if (notifications == null)
                return toReturn;

            foreach (var notification in notifications)
            {
                toReturn.Add(Converters.ConvertNotification(notification));
            }

            return toReturn;
        }

        /// <summary>
        /// Deletes the notifications with the given ids.
        /// </summary>
        /// <param name="ids">List of notification ids</param>
        public void Delete(List<string> ids)
        {
            Client.deleteNotifications(ids.ToArray());
        }
    }
}

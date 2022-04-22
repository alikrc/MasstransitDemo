using MasstransitDemo.Shared;

namespace MasstransitDemo.Api.Models
{
    public class NotificationSubmitted : INotificationSubmitted
    {
        public DateTime NotificationDate { get; set; }

        public string NotificationMessage { get; set; }

        public NotificationType NotificationType { get; set; }
    }
}
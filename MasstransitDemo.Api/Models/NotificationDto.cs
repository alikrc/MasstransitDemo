using MasstransitDemo.Shared;

namespace MasstransitDemo.Api.Models
{
    public class NotificationDto
    {
        public DateTime NotificationDate { get; set; }
        public string NotificationMessage { get; set; }
        public NotificationType NotificationType { get; set; }
    }
}
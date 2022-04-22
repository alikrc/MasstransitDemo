namespace MasstransitDemo.Shared;

public interface INotificationCreated
{
    DateTime NotificationDate { get; }
    string NotificationMessage { get; }
    NotificationType NotificationType { get; }
}
namespace MasstransitDemo.Shared
{
    public interface INotificationSubmitted
    {
        DateTime NotificationDate { get; }
        string NotificationMessage { get; }
        NotificationType NotificationType { get; }
    }
}
using MasstransitDemo.Shared;

namespace MasstransitDemo.Consumer
{
    public interface INotificationProcessor
    {
        Task Process(INotificationSubmitted message);
    }
}
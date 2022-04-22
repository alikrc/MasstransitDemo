using MasstransitDemo.Shared;

namespace Masstransit.Consumer
{
    public interface INotificationProcessor
    {
        Task Process(INotificationSubmitted message);
    }
}
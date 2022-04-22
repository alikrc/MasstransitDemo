using MasstransitDemo.Shared;

namespace MasstransitDemo.Consumer
{
    public class NotificationProcessor : INotificationProcessor
    {
        public async Task Process(INotificationSubmitted message)
        {
            Console.WriteLine(message);
            await Task.Delay(10);
        }
    }
}
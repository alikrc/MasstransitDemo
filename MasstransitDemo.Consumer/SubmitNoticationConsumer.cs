using MassTransit;
using MasstransitDemo.Shared;

namespace MasstransitDemo.Consumer
{
    public class SubmitNoticationConsumer : IConsumer<INotificationSubmitted>
    {
        private readonly INotificationProcessor notificationProcessor;

        public SubmitNoticationConsumer(INotificationProcessor notificationProcessor)
        {
            this.notificationProcessor = notificationProcessor;
        }

        public async Task Consume(ConsumeContext<INotificationSubmitted> context)
        {
            notificationProcessor.Process(context.Message);
        }
    }
}
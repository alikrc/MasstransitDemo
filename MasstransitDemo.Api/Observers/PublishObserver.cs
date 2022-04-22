using MassTransit;
using MassTransit.Util;

namespace MasstransitDemo.Api.Observers
{
    public class PublishObserver : IPublishObserver
    {
        /// <summary>
        /// called right before the message is published (sent to exchange or topic)
        /// </summary>
        public Task PrePublish<T>(PublishContext<T> context)
            where T : class
        {
            return TaskUtil.Completed;
        }

        /// <summary>
        /// called after the message is published (and acked by the broker if RabbitMQ)
        /// </summary>
        public Task PostPublish<T>(PublishContext<T> context)
            where T : class
        {
            return TaskUtil.Completed;
        }

        /// <summary>
        /// called if there was an exception publishing the message
        /// </summary>
        public Task PublishFault<T>(PublishContext<T> context, Exception exception)
            where T : class
        {
            return TaskUtil.Completed;
        }
    }
}
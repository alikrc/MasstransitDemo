using MassTransit;
using MasstransitDemo.Shared;
using System.Text.Json;

namespace MasstransitDemo.Consumer;

public class NotificationCreatedConsumer : IConsumer<INotificationCreated>
{
    public async Task Consume(ConsumeContext<INotificationCreated> context)
    {
        var serializedMessage = JsonSerializer.Serialize(context.Message, new JsonSerializerOptions { });

        Console.WriteLine($"NotificationCreated event consumed. Message: {serializedMessage}");
    }
}
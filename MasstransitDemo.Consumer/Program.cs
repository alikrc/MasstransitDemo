using MassTransit;
using MasstransitDemo.Consumer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureServices((hostContext, services) =>
{
    services.AddSingleton<INotificationProcessor, NotificationProcessor>();
    services.AddSingleton<IConsumeObserver, ConsumeObserver>();
    services.AddMassTransit(busConfigurator =>
    {
        var entryAssembly = Assembly.GetExecutingAssembly();

        busConfigurator.AddConsumers(entryAssembly);
        busConfigurator.UsingRabbitMq((context, busFactoryConfigurator) =>
        {
            busConfigurator.SetKebabCaseEndpointNameFormatter();
            busFactoryConfigurator.Host("rabbitmq", h => { });

            busFactoryConfigurator.ConfigureEndpoints(context);
            busFactoryConfigurator.ConnectConsumeObserver(context.GetRequiredService<IConsumeObserver>());
        });
    });
});

var app = builder.Build();

app.Run();

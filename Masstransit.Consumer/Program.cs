using Masstransit.Consumer;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;

//services.AddMassTransit(x =>
//{
//    var entryAssembly = Assembly.GetAssembly(typeof(INotificationSubmitted));
//

//    x.UsingRabbitMq((context, cfg) =>
//    {
//        cfg.Host("rabbitmq");

//        cfg.ConfigureEndpoints(context);

//        cfg.
//    });
//});

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureServices((hostContext, services) =>
{
    services.AddMassTransit(x =>
    {
        var entryAssembly = Assembly.GetExecutingAssembly();

        x.AddConsumers(entryAssembly);
        x.UsingRabbitMq((context, cfg) =>
        {
            cfg.Host("localhost", "/", h =>
            {
                //h.Username("guest");
                //h.Password("guest");
            });

            cfg.ConfigureEndpoints(context);
        });
    });

    services.AddSingleton<INotificationProcessor, NotificationProcessor>();
});

var app = builder.Build();

app.Run();

//services.AddMassTransit(x =>
//{
//    x.SetKebabCaseEndpointNameFormatter();

//    // By default, sagas are in-memory, but should be changed to a durable
//    // saga repository.
//    x.SetInMemorySagaRepositoryProvider();

//    var entryAssembly = Assembly.GetEntryAssembly();

//    x.AddConsumers(entryAssembly);
//    x.AddSagaStateMachines(entryAssembly);
//    x.AddSagas(entryAssembly);
//    x.AddActivities(entryAssembly);

//    x.UsingInMemory((context, cfg) =>
//    {
//        cfg.ConfigureEndpoints(context);
//    });
//});

//services.AddMassTransitHostedService(true);
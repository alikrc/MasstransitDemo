using MassTransit;
using MasstransitDemo.Api.Observers;
using MasstransitDemo.Shared;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var services = builder.Services;

services.AddSingleton<IPublishObserver, PublishObserver>();
services.AddMassTransit(busConfigurator =>
{
    busConfigurator.SetKebabCaseEndpointNameFormatter();
    busConfigurator.UsingRabbitMq((context, busFactoryConfigurator) =>
    {
        busFactoryConfigurator.Host("rabbitmq", hostConfigurator =>
        {
            //hostConfigurator.Username("guest");
            //hostConfigurator.Password("guest");
        });

        busFactoryConfigurator.ConnectPublishObserver(context.GetRequiredService<IPublishObserver>());
    });
    //EndpointConvention.Map<INotificationSubmitted>(new Uri($"queue:{RabbitMQOptions.TransactionQueue}"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
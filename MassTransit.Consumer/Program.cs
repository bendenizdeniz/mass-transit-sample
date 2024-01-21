using MassTransit;
using MassTransit.Consumer.Consumers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMassTransit(busConfigurator =>
{
    busConfigurator.AddConsumer<ReadingDataEventConsumer>();
    busConfigurator.AddConsumer<SendingDataEventConsumer>();

    busConfigurator.UsingRabbitMq((context, rabbitMqConfigurator) =>
    {
        rabbitMqConfigurator.Host(
            new Uri("***"));

        rabbitMqConfigurator.ConfigureEndpoints(context);
    });
});

var app = builder.Build();
app.Run();

using MassTransit;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddMassTransit(busConfigurator =>
{
    busConfigurator.UsingRabbitMq((context, rabbitMqConfigurator) =>
    {
        rabbitMqConfigurator.Host(
            new Uri("amqps://fskgqixc:r_C4CG8NFB78dEF175g_PRA7Drcbguj3@moose.rmq.cloudamqp.com/fskgqixc"));

        rabbitMqConfigurator.ConfigureEndpoints(context);
    });
});

var app = builder.Build();
app.Urls.Add("http://localhost:5000");
app.MapControllers();
app.Run();
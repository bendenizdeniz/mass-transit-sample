using MassTransit;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddMassTransit(busConfigurator =>
{
    busConfigurator.UsingRabbitMq((context, rabbitMqConfigurator) =>
    {
        rabbitMqConfigurator.Host(
            new Uri("***"));

        rabbitMqConfigurator.ConfigureEndpoints(context);
    });
});

var app = builder.Build();
app.Urls.Add("http://localhost:5000");
app.MapControllers();
app.Run();

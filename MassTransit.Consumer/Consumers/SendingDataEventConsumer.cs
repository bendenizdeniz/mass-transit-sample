using Contracts;

namespace MassTransit.Consumer.Consumers;

public sealed class SendingDataEventConsumer : IConsumer<SendingDataEvent>
{
    public Task Consume(ConsumeContext<SendingDataEvent> context)
    {
        var _message = context.Message;

        var msg = new SendingDataEvent(
            Id: _message.Id,
            Text: _message.Text,
            EventType: _message.EventType,
            CreatedOnUTC: _message.CreatedOnUTC
        );

        Console.WriteLine($"Sending Message Event Triggered: {msg}");
        return Task.CompletedTask;
    }
}
using Contracts;

namespace MassTransit.Consumer.Consumers;

public sealed class ReadingDataEventConsumer : IConsumer<ReadingDataEvent>
{
    public Task Consume(ConsumeContext<ReadingDataEvent> context)
    {
        var _message = context.Message;

        var viewedData = new ReadingDataEvent(
            Id: _message.Id,
            Text: _message.Text,
            EventType: _message.EventType,
            CreatedOnUTC: _message.CreatedOnUTC
        );

        Console.WriteLine($"Read Message Event Triggered: {viewedData}");

        return Task.CompletedTask;
    }
}
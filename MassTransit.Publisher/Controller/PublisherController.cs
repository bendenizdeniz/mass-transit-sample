using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace MassTransit.Publisher.Controller;

public class PublisherController : Microsoft.AspNetCore.Mvc.Controller
{
    private readonly IPublishEndpoint _publisher;

    public PublisherController(IPublishEndpoint publisher)
    {
        _publisher = publisher;
    }

    [HttpPost("post-data")]
    public async Task<SendingDataEvent> PostData()
    {
        var reply = new SendingDataEvent(
            Id: Guid.NewGuid(),
            Text: "Hello World Data",
            EventType: EventEnum.SEND,
            CreatedOnUTC: DateTime.UtcNow
        );

        _publisher.Publish(reply);

        return reply;
    }

    [HttpGet("get-data")]
    public async Task<ReadingDataEvent> GetData()
    {
        var reply = new ReadingDataEvent(
            Id: Guid.NewGuid(),
            Text: "Data Received!",
            EventType: EventEnum.READ,
            CreatedOnUTC: DateTime.UtcNow
        );

        _publisher.Publish(reply);

        return reply;
    }
}
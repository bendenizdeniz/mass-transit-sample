namespace Contracts;

public record SendingDataEvent(Guid Id, string Text, string EventType, DateTime CreatedOnUTC) : IDataEvent(Id, Text,
    EventType, CreatedOnUTC);
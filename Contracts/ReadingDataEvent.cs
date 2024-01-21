namespace Contracts;

public record ReadingDataEvent(Guid Id, string Text, string EventType, DateTime CreatedOnUTC) : IDataEvent(Id, Text,
    EventType, CreatedOnUTC);
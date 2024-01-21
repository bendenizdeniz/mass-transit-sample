namespace Contracts;

public record IDataEvent(Guid Id, string Text, string EventType, DateTime CreatedOnUTC);
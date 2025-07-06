using System;

namespace EventingApp.ApiService.Entities;

public class Event
{
    public required Guid Id { get; set; }
    public required string EventName { get; set; }
    public required string EventType { get; set; }
    // other attrs
}

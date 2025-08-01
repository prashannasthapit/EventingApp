using System.ComponentModel.DataAnnotations;

namespace EventingApp.Contracts.Requests;

public class CreateEventRequestDto
{
    [Required]
    [MaxLength(100)]
    public required string EventName { get; set; }

    [Required]
    public required string EventType { get; set; }
}

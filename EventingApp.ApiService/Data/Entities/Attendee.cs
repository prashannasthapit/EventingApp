using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EventingApp.ApiService.Data.Enums;

namespace EventingApp.ApiService.Data.Entities;

[Table("attendees")]
public class Attendee
{
    public Guid Id { get; init; }

    public Guid UserId { get; init; }

    public required User User { get; init; }

    public Guid EventId { get; init; }

    public required Event Event { get; init; }

    public required RsvpResponse Response { get; init; } = RsvpResponse.Pending;

    public DateTime RespondedAt { get; init; }

    public DateTime UpdatedAt { get; init; }

    public bool IsOrganiser { get; init; }

    [MaxLength(500)]
    public string? Comment { get; init; }

    [MaxLength(100)] public required string Priority { get; set; }

}

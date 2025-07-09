using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EventingApp.ApiService.Data.Enums;

namespace EventingApp.ApiService.Data.Entities;

[Table("attendees")]
public class Attendee
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public required User User { get; set; }

    public Guid EventId { get; set; }

    public required Event Event { get; set; }

    public required RsvpResponse Response { get; set; } = RsvpResponse.Pending;

    public DateTime RespondedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public bool IsOrganiser { get; set; }

    [MaxLength(500)]
    public string? Comment { get; set; }

    public required string Priority { get; set; }

}

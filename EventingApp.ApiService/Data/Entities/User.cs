using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace EventingApp.ApiService.Data.Entities;

[Table("users")]
public class User : IdentityUser<Guid>
{
    [MaxLength(20)] public string Name { get; set; } = string.Empty;

    [MaxLength(30)] public string? Address { get; set; }

    public ICollection<Attendee> Attendees { get; init; } = new List<Attendee>();

    public ICollection<Event> Events { get; init; } = new List<Event>();
}
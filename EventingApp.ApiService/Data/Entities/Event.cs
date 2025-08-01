using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventingApp.ApiService.Data.Entities;

[Table("events")]
public class Event
{
    public Guid Id { get; init; }

    [MaxLength(150)]
    public required string Name { get; init; }

    [MaxLength(100)]
    public required string Type { get; init; }

    [MaxLength(256)]
    public string? Description { get; init; }

    [MaxLength(256)]
    public required string Location { get; init; }

    public required Guid CreatedBy { get; init; }

    [ForeignKey(nameof(CreatedBy))]
    public User? Creator { get; init; }

    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; init; }

    public DateTime StartTime { get; init; }

    public DateTime EndTime { get; init; }
}

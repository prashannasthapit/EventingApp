using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventingApp.ApiService.Data.Entities;

[Table("events")]
public class Event
{
    public Guid Id { get; set; }

    [MaxLength(150)]
    public required string Name { get; set; }

    [MaxLength(100)]
    public required string Type { get; set; }

    [MaxLength(256)]
    public string? Description { get; set; }

    [MaxLength(256)]
    public required string Location { get; set; }

    public required Guid CreatedBy { get; set; }

    [ForeignKey(nameof(CreatedBy))]
    public User? Creator { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }
}

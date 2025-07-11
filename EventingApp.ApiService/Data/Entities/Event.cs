using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventingApp.ApiService.Data.Entities;

[Table("events")]
public class Event
{
    [Key] // not necessary
    public Guid Id { get; set; }

    [DataType("nvarchar")] // ??
    [MaxLength(150)] // n?varchar(120), nvarchar can store unicode
    public required string Name { get; set; }

    [MaxLength(500)]
    public required string Type { get; set; }

    // [Column("desc")]
    [MaxLength(256)]
    public string? Description { get; set; }

    [MaxLength(256)]
    public required string? Location { get; set; }

    public required Guid CreatedBy { get; set; }

    [ForeignKey(nameof(CreatedBy))]
    // UserId = ForeignKey
    public required User Creator { get; set; } // navigation property

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

}

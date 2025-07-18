using EventingApp.ApiService.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventingApp.ApiService.Data.Seeders;

public static class EventsSeeder
{
    public static async Task SeedAsync(DbContext context, CancellationToken cancellationToken)
    {
        var events = new List<Event>
        {
            new Event
            {
                Id = Guid.Parse("a1000001-0000-0000-0000-000000000001"),
                Name = "Tech Expo 2025",
                Type = "Expo",
                Description = "Annual tech exhibition and networking event.",
                Location = "Kathmandu",
                CreatedBy = Guid.Parse("a1b2c3d4-e5f6-7890-abcd-ef0123456789"),
                StartTime = DateTime.SpecifyKind(new DateTime(2025, 8, 1, 10, 0, 0), DateTimeKind.Utc),
                EndTime = DateTime.SpecifyKind(new DateTime(2025, 8, 1, 18, 0, 0), DateTimeKind.Utc)
            },
            new Event
            {
                Id = Guid.Parse("a1000002-0000-0000-0000-000000000002"),
                Name = "Cloud Infrastructure Bootcamp",
                Type = "Bootcamp",
                Description = "Learn Azure and AWS cloud fundamentals.",
                Location = "Pokhara",
                CreatedBy = Guid.Parse("11111111-2222-3333-4444-555555555555"),
                StartTime = DateTime.SpecifyKind(new DateTime(2025, 9, 3, 9, 0, 0), DateTimeKind.Utc),
                EndTime = DateTime.SpecifyKind(new DateTime(2025, 9, 7, 17, 0, 0), DateTimeKind.Utc)
            },
            new Event
            {
                Id = Guid.Parse("a1000003-0000-0000-0000-000000000003"),
                Name = "AI Ethics Panel",
                Type = "Panel",
                Description = "Discussing fairness and responsibility in AI.",
                Location = "Lalitpur",
                CreatedBy = Guid.Parse("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee"),
                StartTime = DateTime.SpecifyKind(new DateTime(2025, 10, 15, 14, 0, 0), DateTimeKind.Utc),
                EndTime = DateTime.SpecifyKind(new DateTime(2025, 10, 15, 17, 0, 0), DateTimeKind.Utc)
            },
            new Event
            {
                Id = Guid.Parse("a1000004-0000-0000-0000-000000000004"),
                Name = "Intro to DevOps",
                Type = "Workshop",
                Description = "CI/CD pipelines and infrastructure automation.",
                Location = "Biratnagar",
                CreatedBy = Guid.Parse("deadbeef-dead-beef-dead-beefdeadbeef"),
                StartTime = DateTime.SpecifyKind(new DateTime(2025, 7, 22, 11, 0, 0), DateTimeKind.Utc),
                EndTime = DateTime.SpecifyKind(new DateTime(2025, 7, 22, 16, 0, 0), DateTimeKind.Utc)
            },
            new Event
            {
                Id = Guid.Parse("a1000005-0000-0000-0000-000000000005"),
                Name = "Digital Marketing Essentials",
                Type = "Seminar",
                Description = "Fundamentals of SEO, SEM and social strategy.",
                Location = "Online",
                CreatedBy = Guid.Parse("01234567-89ab-cdef-0123-456789abcdef"),
                StartTime = DateTime.SpecifyKind(new DateTime(2025, 8, 18, 13, 0, 0), DateTimeKind.Utc),
                EndTime = DateTime.SpecifyKind(new DateTime(2025, 8, 18, 15, 0, 0), DateTimeKind.Utc)
            },
            new Event
            {
                Id = Guid.Parse("a1000006-0000-0000-0000-000000000006"),
                Name = "Startup Incubator Demo Day",
                Type = "Showcase",
                Description = "Pitch event for early-stage startups.",
                Location = "Chitwan",
                CreatedBy = Guid.Parse("a1b2c3d4-e5f6-7890-abcd-ef0123456789"),
                StartTime = DateTime.SpecifyKind(new DateTime(2025, 9, 30, 9, 0, 0), DateTimeKind.Utc),
                EndTime = DateTime.SpecifyKind(new DateTime(2025, 9, 30, 12, 0, 0), DateTimeKind.Utc)
            },
            new Event
            {
                Id = Guid.Parse("a1000007-0000-0000-0000-000000000007"),
                Name = "NextGen Women in Tech",
                Type = "Conference",
                Description = "Empowering women leaders in technology.",
                Location = "Bhaktapur",
                CreatedBy = Guid.Parse("11111111-2222-3333-4444-555555555555"),
                StartTime = DateTime.SpecifyKind(new DateTime(2025, 10, 12, 10, 0, 0), DateTimeKind.Utc),
                EndTime = DateTime.SpecifyKind(new DateTime(2025, 10, 12, 17, 0, 0), DateTimeKind.Utc)
            },
            new Event
            {
                Id = Guid.Parse("a1000008-0000-0000-0000-000000000008"),
                Name = "Unity Game Jam",
                Type = "Hackathon",
                Description = "24-hour Unity game building challenge.",
                Location = "Dharan",
                CreatedBy = Guid.Parse("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee"),
                StartTime = DateTime.SpecifyKind(new DateTime(2025, 11, 5, 10, 0, 0), DateTimeKind.Utc),
                EndTime = DateTime.SpecifyKind(new DateTime(2025, 11, 6, 10, 0, 0), DateTimeKind.Utc)
            },
            new Event
            {
                Id = Guid.Parse("a1000009-0000-0000-0000-000000000009"),
                Name = "FOSS Community Meetup",
                Type = "Meetup",
                Description = "Open-source enthusiasts and developers gathering.",
                Location = "Janakpur",
                CreatedBy = Guid.Parse("deadbeef-dead-beef-dead-beefdeadbeef"),
                StartTime = DateTime.SpecifyKind(new DateTime(2025, 9, 14, 15, 0, 0), DateTimeKind.Utc),
                EndTime = DateTime.SpecifyKind(new DateTime(2025, 9, 14, 18, 0, 0), DateTimeKind.Utc)
            },
            new Event
            {
                Id = Guid.Parse("a1000010-0000-0000-0000-000000000010"),
                Name = "Design Thinking Crash Course",
                Type = "Workshop",
                Description = "Problem solving through creative design.",
                Location = "Itahari",
                CreatedBy = Guid.Parse("01234567-89ab-cdef-0123-456789abcdef"),
                StartTime = DateTime.SpecifyKind(new DateTime(2025, 8, 25, 10, 0, 0), DateTimeKind.Utc),
                EndTime = DateTime.SpecifyKind(new DateTime(2025, 8, 25, 16, 0, 0), DateTimeKind.Utc)
            }
        };


        var existingEventIds = await context.Set<Event>()
            .Where(x => events.Select(ev => ev.Id).Contains(x.Id))
            .Select(x => x.Id)
            .ToListAsync(cancellationToken);

        var nonExistingEvents = events.ExceptBy(existingEventIds, x => x.Id).ToArray();

        if (nonExistingEvents.Length != 0) // or nonExistingEvents.Any()
        {
            context.Set<Event>().AddRange(nonExistingEvents);
            await context.SaveChangesAsync(cancellationToken);
        }
    }
}
using EventingApp.ApiService.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EventingApp.ApiService.Data;

public class EventingDbContext(DbContextOptions options) : 
    IdentityDbContext<User, IdentityRole<Guid>, Guid>(options)
{
    public DbSet<Event> Events { get; set; }
    public DbSet<Attendee> Attendees { get; set; }
}
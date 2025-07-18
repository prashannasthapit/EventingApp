using EventingApp.ApiService.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventingApp.ApiService.Data.Seeders;

public class UsersSeeder
{
    public static async Task SeedAsync(DbContext context, CancellationToken cancellationToken)
    {
        var users = new List<User>
        {
            new User
            {
                Id = Guid.Parse("a1b2c3d4-e5f6-7890-abcd-ef0123456789"),
                Name = "Alice Johnson",
                Email = "alice@example.com",
                Address = "123 Main St"
            },
            new User
            {
                Id = Guid.Parse("11111111-2222-3333-4444-555555555555"),
                Name = "Bob Smith",
                Email = "bob@example.com",
                Address = "456 Oak Ave"
            },
            new User
            {
                Id = Guid.Parse("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee"),
                Name = "Charlie Brown",
                Email = "charlie@example.com",
                Address = "789 Pine Rd"
            },
            new User
            {
                Id = Guid.Parse("deadbeef-dead-beef-dead-beefdeadbeef"),
                Name = "Dana Lee",
                Email = "dana@example.com",
                Address = "101 Maple Blvd"
            },
            new User
            {
                Id = Guid.Parse("01234567-89ab-cdef-0123-456789abcdef"),
                Name = "Evan Wright",
                Email = "evan@example.com",
                Address = "202 Birch Ln"
            }
        };

        var existingIds = await context.Set<User>()
            .Where(x => users.Select(user => user.Id).Contains(x.Id))
            .Select(x=>x.Id)
            .ToListAsync(cancellationToken);

        var nonExistingUsers = users.ExceptBy(existingIds, x => x.Id).ToArray();
        // lazy querying, materialising with ToArray, faster than ToList

        if (nonExistingUsers.Length != 0) // can use .Any()
        {
            context.Set<User>().AddRange(nonExistingUsers); // dont need async, only when no id, need autogen
            await context.SaveChangesAsync(cancellationToken);
        }
        
    }
}
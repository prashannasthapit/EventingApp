using EventingApp.ApiService.Controllers.User.Dto;
using Microsoft.AspNetCore.Mvc;

namespace EventingApp.ApiService.Controllers.User;

public class UsersController : ApiControllerBase
{
    private static readonly List<Data.Entities.User> _users =
    [
        new() { Id = Guid.NewGuid(), Name = "Alice Johnson", Email = "alice@example.com" },
        new() { Id = Guid.NewGuid(), Name = "Bob Smith", Email = "bob@example.com" },
        new() { Id = Guid.NewGuid(), Name = "Charlie Brown", Email = "charlie@example.com" },
        new() { Id = Guid.NewGuid(), Name = "Diana Prince", Email = "diana@example.com" },
        new() { Id = Guid.NewGuid(), Name = "Ethan Hunt", Email = "ethan@example.com" },
        new() { Id = Guid.NewGuid(), Name = "Fiona Gallagher", Email = "fiona@example.com" },
        new() { Id = Guid.NewGuid(), Name = "George Martin", Email = "george@example.com" },
        new() { Id = Guid.NewGuid(), Name = "Hannah Baker", Email = "hannah@example.com" },
        new() { Id = Guid.NewGuid(), Name = "Ivan Petrov", Email = "ivan@example.com" },
        new() { Id = Guid.NewGuid(), Name = "Julia Roberts", Email = "julia@example.com" },
    ];

    [HttpGet]
    public List<Data.Entities.User> GetAll() => _users;

    [HttpGet("{id:guid}")] // api/users/{id}
    public ActionResult<Data.Entities.User> Get([FromRoute] Guid id)
    {
        var user = _users.FirstOrDefault(x => x.Id == id);
        if (user == null)
        {
            return NotFound(new { message = "User not found" });
        }

        return user;
    }
    
    [HttpPost]
    public ActionResult<Data.Entities.User> Create([FromBody] CreateUserRequestDto request)
    {
        var user = new Data.Entities.User
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Email = request.Email
        };
        _users.Add(user);
        return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
    }
}
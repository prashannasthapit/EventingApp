using EventingApp.ApiService.Controllers.User.Dto;
using EventingApp.ApiService.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventingApp.ApiService.Controllers.User;

public class UsersController(EventingDbContext dbContext) : ApiControllerBase
{
    [HttpGet]
    public async Task<List<UserResponse>> GetAll([FromQuery] string? search) =>
        await dbContext.Users
            .Where(x => search == null || x.Name.ToLower().Contains(search.ToLower()))
            .OrderBy(x => x.Name)
            .Select(x => new UserResponse(x.Id, x.Name, x.Email, x.Address))
            .ToListAsync();

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<UserResponse>> Get([FromRoute] Guid id)
    {
        var user = await dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        if (user == null)
            return NotFound(new { message = "User not found" });

        return Ok(new UserResponse(user.Id, user.Name, user.Email, user.Address));
    }

    [HttpPost]
    public async Task<ActionResult<UserResponse>> Create([FromBody] CreateUserRequestDto request)
    {
        var user = new Data.Entities.User
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Email = request.Email,
            Address = request.Address
        };

        dbContext.Users.Add(user);
        await dbContext.SaveChangesAsync();

        return CreatedAtAction(nameof(Get), new { id = user.Id },
            new UserResponse(user.Id, user.Name, user.Email, user.Address));
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateUserRequestDto request)
    {
        var user = await dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        if (user == null)
            return NotFound(new { message = "User not found" });

        user.Name = request.Name;
        user.Email = request.Email;
        user.Address = request.Address;

        await dbContext.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        var user = await dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        if (user == null)
            return NotFound(new { message = "User not found" });

        dbContext.Users.Remove(user);
        await dbContext.SaveChangesAsync();

        return NoContent();
    }
}
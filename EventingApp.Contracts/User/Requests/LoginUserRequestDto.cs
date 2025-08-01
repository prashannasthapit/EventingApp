using System.ComponentModel.DataAnnotations;

namespace EventingApp.Contracts.Requests;

public class LoginUserRequestDto
{
    [Required]
    [EmailAddress]
    public required string Email { get; set; }
    
    public required string Password { get; set; }
}
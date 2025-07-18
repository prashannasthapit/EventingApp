using System.ComponentModel.DataAnnotations;

namespace EventingApp.ApiService.Controllers.User.Dto;

public class CreateUserRequestDto
{
    [Required] // data annotation for validation, called attribute in .NET
    [MaxLength(30)]
    public required string Name { get; set; }
    
    [Required]
    [EmailAddress]
    public required string Email { get; set; }
    
    public required string Address { get; set; }
}
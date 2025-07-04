using System.ComponentModel.DataAnnotations;

namespace EventingApp.ApiService.Controllers.User.Dto;

public class CreateUserRequestDto
{
    [Required] // data annotation for validation, called attribute in .NET
    [MaxLength(30)]
    public string Name { get; set; }
    
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}
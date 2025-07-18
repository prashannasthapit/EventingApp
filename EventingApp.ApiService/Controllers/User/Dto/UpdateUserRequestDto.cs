namespace EventingApp.ApiService.Controllers.User.Dto;

public record UpdateUserRequestDto(
    string Name,
    string Email,
    string Address
);
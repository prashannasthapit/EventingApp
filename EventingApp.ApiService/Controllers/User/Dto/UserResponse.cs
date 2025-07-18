namespace EventingApp.ApiService.Controllers.User.Dto;

public record UserResponse(Guid XId, string XName, string XEmail, string? XAddress);
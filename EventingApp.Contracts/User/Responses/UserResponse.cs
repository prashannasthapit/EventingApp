namespace EventingApp.Contracts.Responses;

public record UserResponse(Guid XId, string XName, string XEmail, string? XAddress);
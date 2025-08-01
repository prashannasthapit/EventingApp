namespace EventingApp.Contracts.Requests;

public record UpdateUserRequestDto(
    string Name,
    string Email,
    string Address
);
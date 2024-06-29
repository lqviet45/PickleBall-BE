namespace PickleBall.Domain.DTOs.ApplicationUserDtos;

public class CreateManagerDto
{
    public string? Email { get; init; }
    public string? Password { get; init; }
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public string? Location { get; init; }
}

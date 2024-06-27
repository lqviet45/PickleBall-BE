using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.DTOs.Enum;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Commands.CreateManager;

public record CreateManagerCommand : IRequest<Result<ApplicationUserDto>>
{
    public Guid OwnerId { get; init; }
    public string? Email { get; init; }
    public string? Password { get; init; }
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public string? Location { get; init; }
    public Role Role { get; init; }
}

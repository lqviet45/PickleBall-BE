using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetUserByFirebaseId;

public record GetUserByFirebaseIdQuery : IRequest<Result<ApplicationUserDto>>
{
    public string? FirebaseId { get; init; }
}

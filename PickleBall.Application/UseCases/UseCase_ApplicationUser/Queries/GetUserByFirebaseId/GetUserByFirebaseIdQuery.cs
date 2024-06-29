using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.DTOs.ApplicationUserDtos;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetUserByFirebaseId;

public record GetUserByFirebaseIdQuery : IRequest<Result<ApplicationUserDto>>
{
    public string? FirebaseId { get; init; }
}

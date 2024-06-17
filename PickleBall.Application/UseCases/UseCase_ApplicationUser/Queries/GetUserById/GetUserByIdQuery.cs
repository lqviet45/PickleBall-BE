using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetUserById;

public class GetUserByIdQuery : IRequest<Result<ApplicationUserDto>>
{
    public Guid Id { get; set; }
    public bool TrackChanges { get; set; } = false;
}

using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.DTOs.ApplicationUserDtos;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetUserById;

public class GetUserByIdQuery : IRequest<Result<ApplicationUserDto>>
{
    public Guid Id { get; set; }
    public bool TrackChanges { get; set; } = false;
}

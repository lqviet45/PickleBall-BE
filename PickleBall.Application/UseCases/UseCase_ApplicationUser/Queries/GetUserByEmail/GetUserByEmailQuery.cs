using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.ApplicationUserDtos;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetUserByEmail;

public class GetUserByEmailQuery : IRequest<Result<ApplicationUserDto>>
{
    public string Email { get; set; } = default!;
    public bool TrackChanges { get; set; } = false;
}

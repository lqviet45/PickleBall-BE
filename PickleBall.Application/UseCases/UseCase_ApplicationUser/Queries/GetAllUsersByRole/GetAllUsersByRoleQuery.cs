using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.ApplicationUserDtos;
using PickleBall.Domain.DTOs.Enum;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetAllUsersByRole;

public class GetAllUsersByRoleQuery : IRequest<Result<IEnumerable<ApplicationUserDto>>>
{
    public Role Role { get; set; }
}

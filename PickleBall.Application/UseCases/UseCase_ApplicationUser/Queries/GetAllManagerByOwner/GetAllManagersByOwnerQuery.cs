using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetAllManagerByOwner;

public class GetAllManagersByOwnerQuery : IRequest<Result<IEnumerable<ApplicationUserDto>>>
{
    public Guid Id { get; set; }
}

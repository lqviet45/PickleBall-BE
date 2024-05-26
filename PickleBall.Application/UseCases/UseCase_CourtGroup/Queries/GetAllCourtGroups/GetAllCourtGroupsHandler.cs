using Ardalis.Result;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetAllCourtGroups;

public class GetAllCitiesHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<GetAllCourtGroupsQuery, Result<IEnumerable<CourtGroup>>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<Result<IEnumerable<CourtGroup>>> Handle(
        GetAllCourtGroupsQuery request,
        CancellationToken cancellationToken
    )
    {
        IEnumerable<CourtGroup> courtGroups =
            await _unitOfWork.RepositoryCourtGroup.GetCourtGroupsAsync(cancellationToken);

        if (courtGroups is null)
            return Result.NotFound("Court Group is not found");

        return Result.Success(courtGroups, "Court Group is found successfully");
    }
}

using Ardalis.Result;
using MediatR;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetAllCourtGroups;

public class GetAllCourtGroupsQuery : IRequest<Result<IEnumerable<CourtGroup>>> { }

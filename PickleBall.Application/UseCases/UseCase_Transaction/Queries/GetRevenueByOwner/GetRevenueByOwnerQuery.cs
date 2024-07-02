using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.TransactionDtos;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetRevenueByOwner;

public class GetRevenueByOwnerQuery : IRequest<Result<RevenueResponseDto>>
{
    public Guid OwnerId { get; init; }
    public int Month { get; init; }
    public int Year { get; init; }
    public bool TrackChanges { get; init; } = false;
}

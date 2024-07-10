using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.TransactionDtos;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetCurrentRevenueByOwner;

public class GetCurrentRevenueByOwnerQuery : IRequest<Result<CurrentRevenueDto>>
{
    public Guid OwnerId { get; set; }
    public bool TrackChanges { get; set; } = false;
}

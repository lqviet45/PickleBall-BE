using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.TransactionDtos;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetRevenueByOwnerId;

public class GetRevenueByOwnerIdQuery : IRequest<Result<RevenueByOwnerIdResponseDto>>
{
    public int Month { get; set; }
    public int Year { get; set; }
    public Guid OwnerId { get; set; }
}
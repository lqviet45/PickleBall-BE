using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.TransactionDtos;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetRevenueTodayByOwnerId;

public class GetRevenueTodayByOwnerIdQuery : IRequest<Result<RevenueByOwnerTodayResponseDto>>
{
    public Guid OwnerId { get; set; }
}
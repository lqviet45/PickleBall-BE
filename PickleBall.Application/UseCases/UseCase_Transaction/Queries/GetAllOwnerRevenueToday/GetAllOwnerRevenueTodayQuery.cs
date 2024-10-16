using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.TransactionDtos;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetAllOwnerRevenueToday;

public class GetAllOwnerRevenueTodayQuery : IRequest<Result<RevenueByAllOwnerTodayResponseDto>>
{
    
}
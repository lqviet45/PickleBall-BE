using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.TransactionDtos;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetAllOwnerRevenue;

public class GetAllOwnerRevenueQuery : IRequest<Result<RevenueByAllOwnerResponseDto>>
{
    public int Month { get; set; }
    public int Year { get; set; }
}
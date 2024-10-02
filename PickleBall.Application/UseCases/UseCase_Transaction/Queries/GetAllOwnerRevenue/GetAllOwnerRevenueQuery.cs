using Ardalis.Result;
using MediatR;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetAllOwnerRevenue;

public class GetAllOwnerRevenueQuery : IRequest<Result<decimal>>
{
    public int Month { get; set; }
    public int Year { get; set; }
}
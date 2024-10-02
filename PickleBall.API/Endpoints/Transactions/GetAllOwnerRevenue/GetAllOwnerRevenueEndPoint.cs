using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetAllOwnerRevenue;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Transactions.GetAllOwnerRevenue;

public class GetAllOwnerRevenueRequest
{
    public int Month { get; init; }
    public int Year { get; init; }
}

public class GetAllOwnerRevenueEndPoint 
    : EndpointBaseAsync.WithRequest<GetAllOwnerRevenueRequest>.WithActionResult
{
    private readonly ISender _sender;

    public GetAllOwnerRevenueEndPoint(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    [Route("/api/transactions/owner-revenue")]
    [SwaggerOperation(
        Summary = "Get all owner revenue",
        Description = "Get all owner revenue",
        OperationId = "Transaction.GetAllOwnerRevenue",
        Tags = new[] { "Transactions" }
    )]
    public override async Task<ActionResult> HandleAsync([FromQuery] GetAllOwnerRevenueRequest request, CancellationToken cancellationToken = new CancellationToken())
    {
        var command = new GetAllOwnerRevenueQuery
        {
            Month = request.Month,
            Year = request.Year
        };
        
        var result = await _sender.Send(command, cancellationToken);
        return result.IsSuccess
            ? Ok(result)
            : BadRequest(result);
    }
}
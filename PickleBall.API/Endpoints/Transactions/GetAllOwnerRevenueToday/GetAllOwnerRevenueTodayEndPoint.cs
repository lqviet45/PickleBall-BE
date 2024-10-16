using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetAllOwnerRevenueToday;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Transactions.GetAllOwnerRevenueToday;

public class GetAllOwnerRevenueTodayEndPoint 
    : EndpointBaseAsync.WithoutRequest.WithActionResult
{
    private readonly ISender _sender;

    public GetAllOwnerRevenueTodayEndPoint(ISender sender)
    {
        _sender = sender;
    }
    

    [HttpGet]
    [Route("/api/transactions/owner-revenue-today")]
    [SwaggerOperation(
        Summary = "Get all owner revenue today",
        Description = "Get all owner revenue today",
        OperationId = "Transaction.GetAllOwnerRevenueToday",
        Tags = new[] { "Transactions" }
    )]
    public override async Task<ActionResult> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        var command = new GetAllOwnerRevenueTodayQuery();
        
        var result = await _sender.Send(command, cancellationToken);
        return result.IsSuccess
            ? Ok(result)
            : BadRequest(result);
    }
}
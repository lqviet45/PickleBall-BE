using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetRevenueByOwnerId;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Transactions.GetRevenueByOwnerIdV2;

public class GetRevenueByOwnerIdEndpoint
    : EndpointBaseAsync.WithRequest<GetRevenueByOwnerIdQuery>.WithActionResult
{
    private readonly ISender _sender;

    public GetRevenueByOwnerIdEndpoint(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet("api/transactions/revenue-by-owner-v2")]
    [SwaggerOperation(
        Summary = "Get revenue by owner id v2",
        Description = "Get revenue by owner id v2",
        OperationId = "Transaction.GetRevenueByOwnerIdV2",
        Tags = new[] { "Transactions" }
    )]
    public override async Task<ActionResult> HandleAsync([FromQuery] GetRevenueByOwnerIdQuery request, CancellationToken cancellationToken = new CancellationToken())
    {
        var result = await _sender.Send(request, cancellationToken);
        
        return Ok(result);
    }
}
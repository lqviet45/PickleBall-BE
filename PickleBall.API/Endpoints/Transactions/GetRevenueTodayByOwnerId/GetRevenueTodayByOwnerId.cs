using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetRevenueTodayByOwnerId;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Transactions.GetRevenueTodayByOwnerId;

public class GetRevenueTodayByOwnerId
    : EndpointBaseAsync.WithRequest<GetRevenueTodayByOwnerIdQuery>.WithActionResult
{
    private readonly ISender _sender;

    public GetRevenueTodayByOwnerId(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet("api/transactions/revenue-today-by-owner")]
    [SwaggerOperation(
        Summary = "Get owner's revenue today by owner id",
        Description = "Get owner's revenue today by owner id",
        OperationId = "Transaction.GetRevenueTodayByOwnerId",
        Tags = new[] { "Transactions" }
    )]
    public override async Task<ActionResult> HandleAsync([FromQuery]GetRevenueTodayByOwnerIdQuery request, CancellationToken cancellationToken = new CancellationToken())
    {
        var result = await _sender.Send(request, cancellationToken);
        
        return Ok(result);
    }
}
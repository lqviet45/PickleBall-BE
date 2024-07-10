using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetCurrentRevenueByOwner;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Transactions.GetCurrentRevenueByOwnerId;

public record GetCurrentRevenueByOwnerIdRequest
{
    [FromRoute]
    public Guid OwnerId { get; set; }
}

public class GetCurrentRevenueByOwnerIdEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<GetCurrentRevenueByOwnerIdRequest>.WithActionResult
{
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    [Route("/api/users/{OwnerId}/revenues/current")]
    [SwaggerOperation(
        Summary = "Get current revenue by owner id",
        Description = "Get current revenue by owner id",
        OperationId = "Transaction.GetCurrentRevenueByOwnerId",
        Tags = new[] { "Transactions" }
    )]
    public override async Task<ActionResult> HandleAsync(
        GetCurrentRevenueByOwnerIdRequest request,
        CancellationToken cancellationToken = default
    )
    {
        var command = new GetCurrentRevenueByOwnerQuery { OwnerId = request.OwnerId };

        var result = await _mediator.Send(command, cancellationToken);

        return Ok(result);
    }
}

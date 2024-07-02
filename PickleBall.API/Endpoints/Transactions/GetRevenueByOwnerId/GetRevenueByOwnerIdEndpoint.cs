using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetRevenueByOwner;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Transactions.GetRevenueByOwnerId;

public record GetRevenueByOwnerIdRequest
{
    [FromRoute]
    public Guid OwnerId { get; init; }

    [FromQuery]
    public int Month { get; init; }

    [FromQuery]
    public int Year { get; init; }
}

public class GetRevenueByOwnerIdEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<GetRevenueByOwnerIdRequest>.WithActionResult
{
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    [Route("/api/users/{OwnerId}/revenues")]
    [SwaggerOperation(
        Summary = "Get revenue by owner id",
        Description = "Get revenue by owner id",
        OperationId = "Transaction.GetRevenueByOwnerId",
        Tags = new[] { "Transactions" }
    )]
    public override async Task<ActionResult> HandleAsync(
        GetRevenueByOwnerIdRequest request,
        CancellationToken cancellationToken = default
    )
    {
        var command = new GetRevenueByOwnerQuery
        {
            OwnerId = request.OwnerId,
            Month = request.Month,
            Year = request.Year
        };

        var result = await _mediator.Send(command, cancellationToken);

        return Ok(result);
    }
}

using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetAllCourtGroups;
using PickleBall.Domain.Entities;

namespace PickleBall.API.Endpoints.CourtGroups;

public class GetAllCourtGroupsEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithoutRequest.WithActionResult
{
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    [Route("/api/court-groups")]
    public override async Task<ActionResult> HandleAsync(
        CancellationToken cancellationToken = default
    )
    {
        Result<IEnumerable<CourtGroup>> result = await _mediator.Send(
            new GetAllCourtGroupsQuery(),
            cancellationToken
        );

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result) : BadRequest(result);

        return Ok(result);
    }
}

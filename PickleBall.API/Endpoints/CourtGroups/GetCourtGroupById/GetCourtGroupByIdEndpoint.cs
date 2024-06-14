using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetCourtGroupById;
using PickleBall.Domain.DTOs;

namespace PickleBall.API.Endpoints.CourtGroups.GetCourtGroupById;

public record GetCourtGroupByIdRequest
{
    [FromRoute]
    public Guid Id { get; set; }

    [FromQuery]
    public bool TrackChanges { get; set; }
}

public class GetCourtGroupByIdEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<GetCourtGroupByIdRequest>.WithActionResult<
        Result<CourtGroupDto>
    >
{
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    [Route("/api/court-groups/{Id}")]
    public override async Task<ActionResult<Result<CourtGroupDto>>> HandleAsync(
        GetCourtGroupByIdRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Result<CourtGroupDto> result = await _mediator.Send(
            new GetCourtGroupByIdQuery { Id = request.Id, TrackChanges = request.TrackChanges },
            cancellationToken
        );

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result) : BadRequest(result);

        return Ok(result);
    }
}

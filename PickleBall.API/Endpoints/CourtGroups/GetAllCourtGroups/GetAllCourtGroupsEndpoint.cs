using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetAllCourtGroups;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Paging;

namespace PickleBall.API.Endpoints.CourtGroups.GetAllCourtGroups;

public record GetAllCourtGroupRequest
{
    [FromQuery]
    public int PageNumber { get; set; } = 1;

    [FromQuery]
    public int PageSize { get; set; } = 10;
}

public class GetAllCourtGroupsEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<GetAllCourtGroupRequest>.WithActionResult
{
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    [Route("/api/court-groups")]
    public override async Task<ActionResult> HandleAsync(
        GetAllCourtGroupRequest request,
        CancellationToken cancellationToken = default
    )
    {
        var courtGroupParameters = new CourtGroupParameters
        {
            PageNumber = request.PageNumber,
            PageSize = request.PageSize
        };

        Result<IEnumerable<CourtGroupDto>> result = await _mediator.Send(
            new GetAllCourtGroupsQuery { CourtGroupParameters = courtGroupParameters },
            cancellationToken
        );

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result) : BadRequest(result);

        return Ok(result);
    }
}

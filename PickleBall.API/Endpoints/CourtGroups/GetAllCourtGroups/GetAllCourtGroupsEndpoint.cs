using System.Text.Json;
using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetAllCourtGroups;
using PickleBall.Domain.DTOs.CourtGroupsDtos;
using PickleBall.Domain.Paging;
using Swashbuckle.AspNetCore.Annotations;

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
    [SwaggerOperation(
        Summary = "Get all court groups",
        Description = "Get all court groups",
        OperationId = "CourtGroups.GetAllCourtGroups",
        Tags = new[] { "CourtGroups" }
    )]
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

        Result<PagedList<CourtGroupDto>> result = await _mediator.Send(
            new GetAllCourtGroupsQuery { CourtGroupParameters = courtGroupParameters },
            cancellationToken
        );

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result) : BadRequest(result);

        // var pagedList = result.Value;

        // Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedList.MetaData));

        return Ok(result);
    }
}

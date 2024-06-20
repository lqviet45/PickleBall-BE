using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.API.Endpoints.CourtGroups.GetCourtGroupById;
using PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetCourtGroupById;
using PickleBall.Application.UseCases.UseCase_CourtYard.Queries.GetAllByCourtGroupId;
using PickleBall.Domain.DTOs;

namespace PickleBall.API.Endpoints.CourtYard.GetAllByCourtGroupId;

public record GetAllByCourtGroupIdRequest
{
    [FromRoute]
    public Guid CourtGroupId { get; set; }
}

public class GetAllCourtYardsByCourtGroupIdEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<GetAllByCourtGroupIdRequest>.WithActionResult<
        Result<IEnumerable<CourtYardDto>>
    >
{
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    [Route("/api/court-groups/{CourtGroupId}/court-yards")]
    public override async Task<ActionResult<Result<IEnumerable<CourtYardDto>>>> HandleAsync(
        GetAllByCourtGroupIdRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Result<CourtGroupDto?> courtGroup = await GetCourtGroupByIdAsync(
            request.CourtGroupId,
            cancellationToken
        );

        if (!courtGroup.IsSuccess)
            return NotFound(courtGroup);

        Result<IEnumerable<CourtYardDto>> result = await _mediator.Send(
            new GetAllCourtYardsByCourtGroupIdQuery { CourtGroupId = request.CourtGroupId },
            cancellationToken
        );

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result) : BadRequest(result);

        return Ok(result);
    }

    private async Task<Result<CourtGroupDto?>> GetCourtGroupByIdAsync(
        Guid courtGroupId,
        CancellationToken cancellationToken = default
    )
    {
        var courtGroup = await _mediator.Send(
            new GetCourtGroupByIdQuery { Id = courtGroupId },
            cancellationToken
        );

        if (!courtGroup.IsSuccess)
            return Result.NotFound("Court Group is not found");

        return courtGroup;
    }
}

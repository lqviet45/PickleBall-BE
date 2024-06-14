using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_District.Queries.GetDistrictById;
using PickleBall.Domain.DTOs;

namespace PickleBall.API.Endpoints.Districts.GetDistrictById;

public record GetDistrictByIdRequest
{
    [FromRoute]
    public int Id { get; init; }

    [FromQuery]
    public bool TrackChanges { get; init; }
}

public class GetDistrictByIdEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<GetDistrictByIdRequest>.WithActionResult<Result<DistrictDto>>
{
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    [Route("/api/districts/{Id}")]
    public override async Task<ActionResult<Result<DistrictDto>>> HandleAsync(
        GetDistrictByIdRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Result<DistrictDto> result = await _mediator.Send(
            new GetDistrictByIdQuery { Id = request.Id, TrackChanges = request.TrackChanges },
            cancellationToken
        );

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result) : BadRequest(result);

        return Ok(result);
    }
}

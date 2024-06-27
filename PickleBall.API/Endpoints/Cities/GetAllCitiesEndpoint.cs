using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetAllCities;
using PickleBall.Domain.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Cities;

public class GetAllCitiesEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithoutRequest.WithActionResult
{
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    [Route("/api/cities")]
    [SwaggerOperation(
        Summary = "Get all cities",
        Description = "Get all cities",
        OperationId = "Cities.GetAll",
        Tags = new[] { "Cities" }
    )]
    public override async Task<ActionResult> HandleAsync(
        CancellationToken cancellationToken = default
    )
    {
        Result<IEnumerable<CityDto>> result = await _mediator.Send(
            new GetAllCitiesQuery(),
            cancellationToken
        );

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result) : BadRequest(result);

        return Ok(result);
    }
}

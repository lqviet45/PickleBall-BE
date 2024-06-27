using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_City.Queries.GetCitiesByName;
using PickleBall.Domain.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Cities
{
    public record GetCitiesByNameRequest
    {
        [FromQuery]
        public string Name { get; set; }
    }

    public class GetCitiesByNameEndpoint
        : EndpointBaseAsync.WithRequest<GetCitiesByNameRequest>.WithActionResult<
            Result<IEnumerable<CityDto>>
        >
    {
        private readonly IMediator _mediator;

        public GetCitiesByNameEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/cities/search")]
        [SwaggerOperation(
            Summary = "Get cities by name",
            Description = "Get cities by name",
            OperationId = "Cities.GetByName",
            Tags = new[] { "Cities" }
        )]
        public override async Task<ActionResult<Result<IEnumerable<CityDto>>>> HandleAsync(
            GetCitiesByNameRequest request,
            CancellationToken cancellationToken = default
        )
        {
            Result<IEnumerable<CityDto>> result = await _mediator.Send(
                new GetCitiesByNameQuery { Name = request.Name },
                cancellationToken
            );

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

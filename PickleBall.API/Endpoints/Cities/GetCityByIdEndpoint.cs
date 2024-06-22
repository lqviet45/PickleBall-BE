using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_City.Queries.GetCityById;
using PickleBall.Domain.DTOs;

namespace PickleBall.API.Endpoints.Cities
{
    public record GetCityByIdRequest
    {
        [FromRoute]
        public int Id { get; set; }
    }

    public class GetCityByIdEndpoint : EndpointBaseAsync.WithRequest<GetCityByIdRequest>.WithActionResult<Result<CityDto>>
    {
        private readonly IMediator _mediator;

        public GetCityByIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/cities/{Id}")]
        public override async Task<ActionResult<Result<CityDto>>> HandleAsync(GetCityByIdRequest request, CancellationToken cancellationToken = default)
        {
            Result<CityDto> result = await _mediator.Send(new GetCityByIdQuery { Id = request.Id }, cancellationToken);

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetCourtGroupsByNameAndCity;
using PickleBall.Domain.DTOs;

namespace PickleBall.API.Endpoints.CourtGroups.GetCourtGroupsByNameAndCity
{
    public record GetCourtGroupsByNameAndCityRequest
    {
        [FromQuery]
        public string Name { get; set; } = string.Empty;
        [FromQuery]
        public string CityName { get; init; }
    }

    public class GetCourtGroupsByNameAndCityEndpoint : EndpointBaseAsync.WithRequest<GetCourtGroupsByNameAndCityRequest>.WithActionResult<Result<IEnumerable<CourtGroupDto>>>
    {
        private readonly IMediator _mediator;

        public GetCourtGroupsByNameAndCityEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/court-groups/search")]
        public override async Task<ActionResult<Result<IEnumerable<CourtGroupDto>>>> HandleAsync(GetCourtGroupsByNameAndCityRequest request, CancellationToken cancellationToken = default)
        {
            Result<IEnumerable<CourtGroupDto>> result = await _mediator.Send(
                               new GetCourtGroupsByNameAndCityQuery
                               {
                                   Name = request.Name,
                                   CityName = request.CityName,
                               },
                               cancellationToken);

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

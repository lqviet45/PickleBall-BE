using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetCourtGroupsByNameOrCity;
using PickleBall.Domain.DTOs;

namespace PickleBall.API.Endpoints.CourtGroups.GetCourtGroupsByNameOrCity
{
    public record GetCourtGroupsByNameOrCityRequest
    {
        [FromQuery]
        public string Name { get; set; } = string.Empty;
        [FromQuery]
        public string CityName { get; set; } = string.Empty;
    }

    public class GetCourtGroupsByNameOrCityEndpoint : EndpointBaseAsync.WithRequest<GetCourtGroupsByNameOrCityRequest>.WithActionResult<Result<IEnumerable<CourtGroupDto>>>
    {
        private readonly IMediator _mediator;

        public GetCourtGroupsByNameOrCityEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/court-groups/search")]
        public override async Task<ActionResult<Result<IEnumerable<CourtGroupDto>>>> HandleAsync(GetCourtGroupsByNameOrCityRequest request, CancellationToken cancellationToken = default)
        {
            Result<IEnumerable<CourtGroupDto>> result = await _mediator.Send(
                               new GetCourtGroupsByNameOrCityQuery
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

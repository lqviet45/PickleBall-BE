using System.Text.Json;
using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetCourtGroupsByNameOrCity;
using PickleBall.Domain.DTOs.CourtGroupsDtos;
using PickleBall.Domain.Paging;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.CourtGroups.GetCourtGroupsByNameOrCity
{
    public record GetCourtGroupsByNameOrCityRequest
    {
        [FromQuery]
        public string Name { get; set; } = string.Empty;

        [FromQuery]
        public string CityName { get; set; } = string.Empty;

        [FromQuery]
        public int PageNumber { get; set; } = 1;

        [FromQuery]
        public int PageSize { get; set; } = 10;
    }

    public class GetCourtGroupsByNameOrCityEndpoint
        : EndpointBaseAsync.WithRequest<GetCourtGroupsByNameOrCityRequest>.WithActionResult<
            Result<IEnumerable<CourtGroupDto>>
        >
    {
        private readonly IMediator _mediator;

        public GetCourtGroupsByNameOrCityEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/court-groups/search")]
        [SwaggerOperation(
            Summary = "Get court groups by name or city",
            Description = "Get court groups by name or city",
            OperationId = "CourtGroups.GetCourtGroupsByNameOrCity",
            Tags = new[] { "CourtGroups" }
        )]
        public override async Task<ActionResult<Result<IEnumerable<CourtGroupDto>>>> HandleAsync(
            GetCourtGroupsByNameOrCityRequest request,
            CancellationToken cancellationToken = default
        )
        {
            var courtGroupParameters = new CourtGroupParameters
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize,
            };

            Result<PagedList<CourtGroupDto>> result = await _mediator.Send(
                new GetCourtGroupsByNameOrCityQuery
                {
                    Name = request.Name,
                    CityName = request.CityName,
                    CourtGroupParameters = courtGroupParameters,
                },
                cancellationToken
            );

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            // var pagedList = result.Value;

            // Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedList.MetaData));

            return Ok(result);
        }
    }
}

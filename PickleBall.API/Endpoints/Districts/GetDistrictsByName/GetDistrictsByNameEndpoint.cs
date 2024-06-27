using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_District.Queries.GetDistrictByName;
using PickleBall.Domain.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Districts.GetDistrictsByName
{
    public record GetDistrictsByNameRequest
    {
        [FromQuery]
        public string Name { get; set; } = string.Empty;
    }

    public class GetDistrictsByNameEndpoint
        : EndpointBaseAsync.WithRequest<GetDistrictsByNameRequest>.WithActionResult<
            IEnumerable<DistrictDto>
        >
    {
        private readonly IMediator _mediator;

        public GetDistrictsByNameEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/districts/search")]
        [SwaggerOperation(
            Summary = "Get districts by name",
            Description = "Get districts by name",
            OperationId = "Districts.GetByName",
            Tags = new[] { "Districts" }
        )]
        public override async Task<ActionResult<IEnumerable<DistrictDto>>> HandleAsync(
            GetDistrictsByNameRequest request,
            CancellationToken cancellationToken = default
        )
        {
            Result<IEnumerable<DistrictDto>> result = await _mediator.Send(
                new GetDistrictsByNameQuery { Name = request.Name, },
                cancellationToken
            );

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

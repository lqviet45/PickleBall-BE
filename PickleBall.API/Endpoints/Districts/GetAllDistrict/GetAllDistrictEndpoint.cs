using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_District.Queries.GetAllDistrict;
using PickleBall.Domain.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Districts.GetAllDistrict
{
    public class GetAllDistrictEndpoint
        : EndpointBaseAsync.WithoutRequest.WithActionResult<Result<IEnumerable<DistrictDto>>>
    {
        private readonly IMediator _mediator;

        public GetAllDistrictEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/districts")]
        [SwaggerOperation(
            Summary = "Get all districts",
            Description = "Get all districts",
            OperationId = "Districts.GetAll",
            Tags = new[] { "Districts" }
        )]
        public override async Task<ActionResult<Result<IEnumerable<DistrictDto>>>> HandleAsync(
            CancellationToken cancellationToken = default
        )
        {
            Result<IEnumerable<DistrictDto>> result = await _mediator.Send(
                new GetAllDistrictQuery(),
                cancellationToken
            );

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

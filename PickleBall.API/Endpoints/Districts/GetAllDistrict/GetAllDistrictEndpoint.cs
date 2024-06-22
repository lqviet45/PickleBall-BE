using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_District.Queries.GetAllDistrict;
using PickleBall.Domain.DTOs;

namespace PickleBall.API.Endpoints.Districts.GetAllDistrict
{
    public class GetAllDistrictEndpoint : EndpointBaseAsync.WithoutRequest.WithActionResult<Result<IEnumerable<DistrictDto>>>
    {
        private readonly IMediator _mediator;

        public GetAllDistrictEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/districts")]
        public override async Task<ActionResult<Result<IEnumerable<DistrictDto>>>> HandleAsync(CancellationToken cancellationToken = default)
        {
            Result<IEnumerable<DistrictDto>> result = await _mediator.Send(new GetAllDistrictQuery(), cancellationToken);

            if (!result.IsSuccess)
                return result.IsNotFound()? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Ward.Queries;
using PickleBall.Domain.DTOs;

namespace PickleBall.API.Endpoints.Wards.GetAllWards
{
    public class GetAllWardsEndpoint : EndpointBaseAsync.WithoutRequest.WithActionResult<Result<IEnumerable<WardDto>>>
    {
        private readonly IMediator _mediator;

        public GetAllWardsEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("api/wards")]
        public override async Task<ActionResult<Result<IEnumerable<WardDto>>>> HandleAsync(CancellationToken cancellationToken = default)
        {
            Result<IEnumerable<WardDto>> result = await _mediator.Send(new GetAllWardQuery(), cancellationToken);

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

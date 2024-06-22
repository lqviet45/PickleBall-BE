using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Ward.Queries.GetWardsByName;
using PickleBall.Domain.DTOs;

namespace PickleBall.API.Endpoints.Wards.GetWardsByName
{
    public record GetWardsByNameRequest
    {
        [FromQuery]
        public string Name { get; set; } = string.Empty;
    }

    public class GetWardsByNameEndpoint : EndpointBaseAsync.WithRequest<GetWardsByNameRequest>.WithActionResult<Result<IEnumerable<WardDto>>>
    {
        private readonly IMediator _mediator;

        public GetWardsByNameEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("api/wards/search")]
        public override async Task<ActionResult<Result<IEnumerable<WardDto>>>> HandleAsync(GetWardsByNameRequest request, CancellationToken cancellationToken = default)
        {
            Result<IEnumerable<WardDto>> result = await _mediator.Send(new GetWardsByNameQuery { Name = request.Name }, cancellationToken);

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

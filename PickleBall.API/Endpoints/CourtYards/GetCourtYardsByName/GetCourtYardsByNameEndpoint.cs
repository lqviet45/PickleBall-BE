using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_CourtYard.Queries.GetCourtYardsByName;
using PickleBall.Domain.DTOs;

namespace PickleBall.API.Endpoints.CourtYards.GetCourtYardsByName
{
    public record GetCourtYardsByNameRequest
    {
        [FromQuery]
        public string Name { get; init; } = string.Empty;
    }

    public class GetCourtYardsByNameEndpoint : EndpointBaseAsync.WithRequest<GetCourtYardsByNameRequest>
        .WithActionResult<Result<IEnumerable<CourtYardDto>>>
    {
        private readonly IMediator _mediator;

        public GetCourtYardsByNameEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/court-yards/search")]
        public override async Task<ActionResult<Result<IEnumerable<CourtYardDto>>>> HandleAsync(GetCourtYardsByNameRequest request, CancellationToken cancellationToken = default)
        {
            Result<IEnumerable<CourtYardDto>> result = await _mediator.Send(
                                           new GetCourtYardsByNameQuery { Name = request.Name },
                                           cancellationToken);

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

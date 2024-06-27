using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_CourtYard.Queries.GetAllCourtYards;
using PickleBall.Domain.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.CourtYards.GetAllCourtYard
{
    public class GetAllCourtYardEndpoint
        : EndpointBaseAsync.WithoutRequest.WithActionResult<Result<IEnumerable<CourtYardDto>>>
    {
        private readonly IMediator _mediator;

        public GetAllCourtYardEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/court-yards")]
        [SwaggerOperation(
            Summary = "Get all court yards",
            Description = "Get all court yards",
            OperationId = "CourtYards.GetAll",
            Tags = new[] { "CourtYards" }
        )]
        public override async Task<ActionResult<Result<IEnumerable<CourtYardDto>>>> HandleAsync(
            CancellationToken cancellationToken = default
        )
        {
            Result<IEnumerable<CourtYardDto>> result = await _mediator.Send(
                new GetAllCourtYardsQuery(),
                cancellationToken
            );

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

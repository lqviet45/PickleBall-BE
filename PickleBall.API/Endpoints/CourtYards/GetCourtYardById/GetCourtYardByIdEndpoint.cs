using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_CourtYard.Queries.GetCourtYardById;
using PickleBall.Domain.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.CourtYards.GetCourtYardById
{
    public record GetCourtYardByIdRequest
    {
        [FromRoute]
        public Guid Id { get; set; }
    }

    public class GetCourtYardByIdEndpoint
        : EndpointBaseAsync.WithRequest<GetCourtYardByIdRequest>.WithActionResult<
            Result<CourtYardDto>
        >
    {
        private readonly IMediator _mediator;

        public GetCourtYardByIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/court-yards/{Id}")]
        [SwaggerOperation(
            Summary = "Get a court yard by id",
            Description = "Get a court yard by id",
            OperationId = "CourtYards.GetById",
            Tags = new[] { "CourtYards" }
        )]
        public override async Task<ActionResult<Result<CourtYardDto>>> HandleAsync(
            GetCourtYardByIdRequest request,
            CancellationToken cancellationToken = default
        )
        {
            Result<CourtYardDto> result = await _mediator.Send(
                new GetCourtYardByIdQuery { CourtYardId = request.Id },
                cancellationToken
            );

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

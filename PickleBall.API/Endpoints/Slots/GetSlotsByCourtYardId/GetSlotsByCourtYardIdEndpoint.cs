using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_CourtYard.Queries.GetCourtYardById;
using PickleBall.Application.UseCases.UseCase_Slot.Queries.GetSlotsByCourtYardId;
using PickleBall.Domain.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Slots.GetSlotsByCourtYardId
{
    public record GetSlotsByCourtYardIdRequest
    {
        [FromRoute]
        public Guid CourtYardId { get; init; }
    }

    public class GetSlotsByCourtYardIdEndpoint
        : EndpointBaseAsync.WithRequest<GetSlotsByCourtYardIdRequest>.WithActionResult<
            Result<IEnumerable<SlotDto>>
        >
    {
        private readonly IMediator _mediator;

        public GetSlotsByCourtYardIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/court-yards/{CourtYardId}/slots")]
        [SwaggerOperation(
            Summary = "Get slots by court yard id",
            Description = "Get slots by court yard id",
            OperationId = "Slots.GetByCourtYardId",
            Tags = new[] { "Slots" }
        )]
        public override async Task<ActionResult<Result<IEnumerable<SlotDto>>>> HandleAsync(
            GetSlotsByCourtYardIdRequest request,
            CancellationToken cancellationToken = default
        )
        {
            Result<CourtYardDto> courtYard = await GetCourtYardByIdAsync(
                request.CourtYardId,
                cancellationToken
            );

            if (!courtYard.IsSuccess)
                return NotFound(courtYard);

            Result<IEnumerable<SlotDto>> result = await _mediator.Send(
                new GetSlotsByCourtYardIdQuery { CourtYardId = request.CourtYardId },
                cancellationToken
            );

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }

        private async Task<Result<CourtYardDto>> GetCourtYardByIdAsync(
            Guid courtYardId,
            CancellationToken cancellationToken = default
        )
        {
            var courtYard = await _mediator.Send(
                new GetCourtYardByIdQuery { CourtYardId = courtYardId },
                cancellationToken
            );

            if (!courtYard.IsSuccess)
                return Result.NotFound("Court Yard is not found");

            return courtYard;
        }
    }
}

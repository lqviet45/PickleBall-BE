using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Slot.Queries.GetSlotsByCourtYardIdAndDateBooking;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Paging;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Slots.GetSlotsByCourtYardIdAndDateBooking
{
    public record GetSlotsByCourtYardIdAndDateBookingRequest
    {
        [FromRoute]
        public Guid CourtYardId { get; set; }

        [FromQuery]
        public DateTime DateBooking { get; set; }
    }

    public class GetSlotsByCourtYardIdAndDateBookingEndpoint : EndpointBaseAsync.WithRequest<GetSlotsByCourtYardIdAndDateBookingRequest>.WithActionResult
    {
        private readonly IMediator _mediator;

        public GetSlotsByCourtYardIdAndDateBookingEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/courtyards/{CourtYardId}/slots")]
        [SwaggerOperation(
            Summary = "Get slots by court yard id and date booking",
            Description = "Get slots by court yard id and date booking",
            OperationId = "Slots.GetSlotsByCourtYardIdAndDateBooking",
            Tags = new[] { "Slots" }
        )]
        public override async Task<ActionResult> HandleAsync(GetSlotsByCourtYardIdAndDateBookingRequest request, CancellationToken cancellationToken = default)
        {
            Result<IEnumerable<SlotDto>> result = await _mediator.Send(
                               new GetSlotsByCourtYardIdAndDateBookingQuery
                               {
                                   CourtYardId = request.CourtYardId,
                                   DateBooking = request.DateBooking
                               },
                               cancellationToken);

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

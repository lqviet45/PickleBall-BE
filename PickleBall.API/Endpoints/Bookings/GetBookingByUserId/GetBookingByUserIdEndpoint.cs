using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Booking.Queries.GetBookingByUserId;
using PickleBall.Domain.DTOs;

namespace PickleBall.API.Endpoints.Bookings.GetBookingByUserId
{
    public record GetBookingByUserIdRequest
    {
        [FromRoute]
        public Guid UserId { get; set; }
    }

    public class GetBookingByUserIdEndpoint : EndpointBaseAsync.WithRequest<GetBookingByUserIdRequest>.WithActionResult<Result<IEnumerable<BookingDto>>>
    {
        private readonly IMediator _mediator;

        public GetBookingByUserIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/users/{UserId}/bookings")]
        public override async Task<ActionResult<Result<IEnumerable<BookingDto>>>> HandleAsync(GetBookingByUserIdRequest request, CancellationToken cancellationToken = default)
        {
            Result<IEnumerable<BookingDto>> result = await _mediator.Send(
                new GetBookingByUserIdQuery { UserId = request.UserId },
                cancellationToken);

            if(!result.IsSuccess)
                return result.IsNotFound()? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Booking.Queries.GetBookingById;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;

namespace PickleBall.API.Endpoints.Bookings.GetBookingById
{
    public record GetBookingByIdRequest
    {
        [FromRoute]
        public Guid BookingId { get; init; }
    }

    public class GetBookingByIdEndpoint : EndpointBaseAsync.WithRequest<GetBookingByIdRequest>.WithActionResult<Result<BookingDto>>
    {
        private readonly IMediator _mediator;

        public GetBookingByIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("api/bookings/{BookingId}/detail")]
        public override async Task<ActionResult<Result<BookingDto>>> HandleAsync(GetBookingByIdRequest request, CancellationToken cancellationToken = default)
        {
            Result<BookingDto> result = await _mediator.Send(
                                              new GetBookingByIdQuery
                                              {
                                                  BookingId = request.BookingId,
                                              },
                                              cancellationToken);

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

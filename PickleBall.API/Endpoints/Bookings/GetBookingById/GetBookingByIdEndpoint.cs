using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Booking.Queries.GetBookingById;
using PickleBall.Domain.DTOs.BookingDtos;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Bookings.GetBookingById
{
    public record GetBookingByIdRequest
    {
        [FromRoute]
        public Guid BookingId { get; init; }
    }

    public class GetBookingByIdEndpoint
        : EndpointBaseAsync.WithRequest<GetBookingByIdRequest>.WithActionResult<Result<BookingDto>>
    {
        private readonly IMediator _mediator;

        public GetBookingByIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("api/bookings/{BookingId}/detail")]
        [SwaggerOperation(
            Summary = "Get a booking by id",
            Description = "Get a booking by id",
            OperationId = "Bookings.GetById",
            Tags = new[] { "Bookings" }
        )]
        public override async Task<ActionResult<Result<BookingDto>>> HandleAsync(
            GetBookingByIdRequest request,
            CancellationToken cancellationToken = default
        )
        {
            var command = new GetBookingByIdQuery { BookingId = request.BookingId, };
            Result<BookingDto> result = await _mediator.Send(command, cancellationToken);

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

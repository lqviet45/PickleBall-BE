using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Booking.Queries.GetAllBookings;
using PickleBall.Domain.DTOs;

namespace PickleBall.API.Endpoints.Bookings.GetAllBookings;

public class GetAllBookingsEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithoutRequest.WithActionResult
{
    [HttpGet]
    [Route("/api/bookings")]
    public override async Task<ActionResult> HandleAsync(
        CancellationToken cancellationToken = default
    )
    {
        Result<IEnumerable<BookingDto>> result = await mediator.Send(
            new GetAllBookingsQuery(),
            cancellationToken
        );

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result) : BadRequest(result);

        return Ok(result);
    }
}

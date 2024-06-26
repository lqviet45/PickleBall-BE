using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Booking.Queries.GetAllBookings;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Paging;

namespace PickleBall.API.Endpoints.Bookings.GetAllBookings;

public record GetAllBookingsRequest
{
    [FromQuery]
    public int PageNumber { get; set; } = 1;

    [FromQuery]
    public int PageSize { get; set; } = 10;
}

public class GetAllBookingsEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<GetAllBookingsRequest>.WithActionResult
{
    [HttpGet]
    [Route("/api/bookings")]
    public override async Task<ActionResult> HandleAsync(
        GetAllBookingsRequest request,
        CancellationToken cancellationToken = default
    )
    {
        var bookingParameters = new BookingParameters
        {
            PageNumber = request.PageNumber,
            PageSize = request.PageSize
        };

        Result<IEnumerable<BookingDto>> result = await mediator.Send(
            new GetAllBookingsQuery { BookingParameters = bookingParameters },
            cancellationToken
        );

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result) : BadRequest(result);

        return Ok(result);
    }
}

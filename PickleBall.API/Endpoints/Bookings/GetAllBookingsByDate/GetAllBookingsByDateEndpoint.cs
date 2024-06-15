using System.Globalization;
using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Booking.Queries;
using PickleBall.Domain.DTOs;

namespace PickleBall.API.Endpoints.Bookings.GetAllBookingsByDate;

public record GetAllBookingsByDateRequest
{
    [FromRoute]
    public string Date { get; set; }
}

public class GetAllBookingsByDateEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<GetAllBookingsByDateRequest>.WithActionResult<
        Result<IEnumerable<BookingDto>>
    >
{
    [HttpGet]
    [Route("/api/bookings/{Date}")]
    public override async Task<ActionResult<Result<IEnumerable<BookingDto>>>> HandleAsync(
        GetAllBookingsByDateRequest request,
        CancellationToken cancellationToken = default
    )
    {
        if (!ValidateDate(request.Date, out DateTime parsedDate))
        {
            return BadRequest($"Invalid date format. Please use DD-MM-YYYY or YYYY-MM-DD.");
        }

        Result<IEnumerable<BookingDto>> result = await mediator.Send(
            new GetAllBookingsByDateQuery { Date = parsedDate },
            cancellationToken
        );

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result) : BadRequest(result);

        return Ok(result);
    }

    private static bool ValidateDate(string inputDate, out DateTime parsedDate)
    {
        string[] formats = ["dd-MM-yyyy", "yyyy-MM-dd"];
        return DateTime.TryParseExact(
            inputDate,
            formats,
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out parsedDate
        );
    }
}

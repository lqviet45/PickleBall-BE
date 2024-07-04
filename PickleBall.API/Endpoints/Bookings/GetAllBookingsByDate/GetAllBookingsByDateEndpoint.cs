using System.Globalization;
using System.Text.Json;
using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Booking.Queries;
using PickleBall.Domain.DTOs.BookingDtos;
using PickleBall.Domain.Paging;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Bookings.GetAllBookingsByDate;

public record GetAllBookingsByDateRequest
{
    [FromRoute]
    public string Date { get; set; }

    [FromQuery]
    public int PageNumber { get; set; } = 1;

    [FromQuery]
    public int PageSize { get; set; } = 10;
}

public class GetAllBookingsByDateEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<GetAllBookingsByDateRequest>.WithActionResult<
        Result<IEnumerable<BookingDto>>
    >
{
    [HttpGet]
    [Route("/api/bookings/{Date}")]
    [SwaggerOperation(
        Summary = "Get all bookings by date",
        Description = "Get all bookings by date",
        OperationId = "Bookings.GetByDate",
        Tags = new[] { "Bookings" }
    )]
    public override async Task<ActionResult<Result<IEnumerable<BookingDto>>>> HandleAsync(
        GetAllBookingsByDateRequest request,
        CancellationToken cancellationToken = default
    )
    {
        if (!ValidateDate(request.Date, out DateTime parsedDate))
        {
            return BadRequest($"Invalid date format. Please use DD-MM-YYYY or YYYY-MM-DD.");
        }

        var command = new GetAllBookingsByDateQuery
        {
            Date = parsedDate,
            BookingParameters = new BookingParameters
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize
            }
        };

        Result<PagedList<BookingDto>> result = await mediator.Send(command, cancellationToken);

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result) : BadRequest(result);

        // var pagedList = result.Value;

        // Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(pagedList.MetaData));

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

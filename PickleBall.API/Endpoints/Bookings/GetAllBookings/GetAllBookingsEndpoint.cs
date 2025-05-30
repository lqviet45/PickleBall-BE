using System.Text.Json;
using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Booking.Queries.GetAllBookings;
using PickleBall.Domain.DTOs.BookingDtos;
using PickleBall.Domain.Paging;
using Swashbuckle.AspNetCore.Annotations;

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
    // [Authorize]
    [SwaggerOperation(
        Summary = "Get all bookings",
        Description = "Get all bookings",
        OperationId = "Bookings.GetAll",
        Tags = new[] { "Bookings" }
    )]
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

        Result<PagedList<BookingDto>> result = await mediator.Send(
            new GetAllBookingsQuery { BookingParameters = bookingParameters },
            cancellationToken
        );

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result) : BadRequest(result);

        // var pagedList = result.Value;

        // Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedList.MetaData));

        return Ok(result);
    }
}

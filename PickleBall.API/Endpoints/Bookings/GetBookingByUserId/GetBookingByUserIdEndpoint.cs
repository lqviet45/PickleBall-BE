using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Booking.Queries.GetBookingByUserId;
using PickleBall.Domain.DTOs.BookingDtos;
using PickleBall.Domain.Entities.Enums;
using PickleBall.Domain.Paging;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Bookings.GetBookingByUserId
{
    public record GetBookingByUserIdRequest
    {
        [FromRoute]
        public Guid UserId { get; set; }

        [FromQuery]
        public int PageNumber { get; set; } = 1;

        [FromQuery]
        public int PageSize { get; set; } = 10;

        [FromQuery]
        public BookingStatus? BookingStatus { get; set; }
    }

    public class GetBookingByUserIdEndpoint
        : EndpointBaseAsync.WithRequest<GetBookingByUserIdRequest>.WithActionResult<
            Result<IEnumerable<BookingDto>>
        >
    {
        private readonly IMediator _mediator;

        public GetBookingByUserIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/users/{UserId}/bookings")]
        // [Authorize(Roles = "Customer")]
        [SwaggerOperation(
            Summary = "Get bookings by user id",
            Description = "Get bookings by user id and filter with booking status",
            OperationId = "Bookings.GetByUserId",
            Tags = new[] { "Bookings" }
        )]
        public override async Task<ActionResult<Result<IEnumerable<BookingDto>>>> HandleAsync(
            GetBookingByUserIdRequest request,
            CancellationToken cancellationToken = default
        )
        {
            var command = new GetBookingByUserIdQuery
            {
                UserId = request.UserId,
                BookingStatus = request.BookingStatus,
                BookingParameters = new BookingParameters
                {
                    PageNumber = request.PageNumber,
                    PageSize = request.PageSize
                }
            };

            Result<PagedList<BookingDto>> result = await _mediator.Send(command, cancellationToken);

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            // var pagedList = result.Value;

            // Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedList.MetaData));

            return Ok(result);
        }
    }
}

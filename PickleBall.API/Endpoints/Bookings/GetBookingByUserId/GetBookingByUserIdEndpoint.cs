using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Booking.Queries.GetBookingByUserId;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.DTOs.BookingDtos;
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
        [SwaggerOperation(
            Summary = "Get bookings by user id",
            Description = "Get bookings by user id",
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
                BookingParameters = new BookingParameters
                {
                    PageNumber = request.PageNumber,
                    PageSize = request.PageSize
                }
            };

            Result<IEnumerable<BookingDto>> result = await _mediator.Send(
                command,
                cancellationToken
            );

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

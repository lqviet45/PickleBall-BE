using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.Abstractions;
using PickleBall.Application.UseCases.UseCase_Booking.Queries.GetBookingByUserId;
using PickleBall.Application.UseCases.UseCase_Booking.Queries.GetBookingsByCourtGroupId;
using PickleBall.Domain.DTOs.BookingDtos;
using PickleBall.Domain.Paging;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Bookings.GetBookingsByCourtGroupId
{
    public record GetBookingsByCourtGroupIdRequest
    {
        [FromRoute]
        public Guid CourtGroupId { get; init; }

        [FromQuery]
        public int PageNumber { get; init; } = 1;

        [FromQuery]
        public int PageSize { get; init; } = 10;
    }

    public class GetBookingsByCourtGroupIdEndpoint : EndpointBaseAsync.WithRequest<GetBookingsByCourtGroupIdRequest>.WithActionResult
    {
        private readonly IMediator _mediator;

        public GetBookingsByCourtGroupIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/court-groups/{CourtGroupId}/bookings")]
        [SwaggerOperation(
            Summary = "Get bookings by court group id",
            Description = "Get bookings by court group id",
            OperationId = "Bookings.GetByCourtGroupId",
            Tags = new[] { "Bookings" }
        )]
        public override async Task<ActionResult> HandleAsync(GetBookingsByCourtGroupIdRequest request, CancellationToken cancellationToken = default)
        {
            var query = new GetBookingsByCourtGroupIdQuery
            {
                CourtGroupId = request.CourtGroupId,
                BookingParameters = new BookingParameters
                {
                    PageNumber = request.PageNumber,
                    PageSize = request.PageSize
                }
            };

            Result<PagedList<BookingDto>> result = await _mediator.Send(query, cancellationToken);
            
            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

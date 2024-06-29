using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_BookMark.Queries.GetBookMarkByUserIdAndCourtGroupId;
using PickleBall.Domain.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.BookMarks
{
    public record GetBookMarkByUserIdAndCourtGroupIdRequest
    {
        [FromQuery]
        public Guid UserId { get; set; }
        [FromQuery]
        public Guid CourtGroupId { get; set; }
    }

    public class GetBookMarkByUserIdAndCourtGroupIdEndpoint : EndpointBaseAsync.WithRequest<GetBookMarkByUserIdAndCourtGroupIdRequest>.WithActionResult<Result<BookMarkDto>>
    {
        private readonly IMediator _mediator;

        public GetBookMarkByUserIdAndCourtGroupIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/bookmarks")]
        [SwaggerOperation(
            Summary = "Get bookmark by user id and court group id",
            Description = "Get bookmark by user id and court group id",
            OperationId = "BookMarks.GetBookMarkByUserIdAndCourtGroupId",
            Tags = new[] { "BookMarks" }
        )]
        public override async Task<ActionResult<Result<BookMarkDto>>> HandleAsync(GetBookMarkByUserIdAndCourtGroupIdRequest request, CancellationToken cancellationToken = default)
        {
            Result<BookMarkDto> result = await _mediator.Send(
                new GetBookMarkByUserIdAndCourtGroupIdQuery
                {
                    UserId = request.UserId,
                    CourtGroupId = request.CourtGroupId
                },
                cancellationToken);

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_BookMark.Queries.GetBookMarksByCourtGroupName;
using PickleBall.Domain.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.BookMarks
{
    public record GetBookMarksByCourtGroupNameRequest
    {
        [FromQuery]
        public string CourtGroupName { get; set; } = string.Empty;
    }

    public class GetBookMarksByCourtGroupName : EndpointBaseAsync
        .WithRequest<GetBookMarksByCourtGroupNameRequest>
        .WithActionResult<Result<IEnumerable<BookMarkDto>>>
    {
        private readonly IMediator _mediator;

        public GetBookMarksByCourtGroupName(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/bookmarks")]
        [SwaggerOperation(
            Summary = "Get all bookmarks by court group name",
            Description = "Get all bookmarks by court group name",
            OperationId = "BookMarks.GetBookMarksByCourtGroupName",
            Tags = new[] { "BookMarks" }
        )]
        public override async Task<ActionResult<Result<IEnumerable<BookMarkDto>>>> HandleAsync(GetBookMarksByCourtGroupNameRequest request, CancellationToken cancellationToken = default)
        {
            var result = await _mediator.Send(new GetBookMarksByCourtGroupNameQuery
            {
                CourtGroupName = request.CourtGroupName
            });

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

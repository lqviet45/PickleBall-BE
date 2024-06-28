using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_BookMark.Queries.GetBookMarksByCourtGroupName;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Paging;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.BookMarks
{
    public record GetBookMarksByCourtGroupNameRequest
    {
        [FromQuery]
        public string CourtGroupName { get; set; } = string.Empty;

        [FromQuery]
        public int PageNumber { get; set; } = 1;

        [FromQuery]
        public int PageSize { get; set; } = 10;
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
        [Route("/api/bookmarks/search")]
        [SwaggerOperation(
            Summary = "Get all bookmarks by court group name",
            Description = "Get all bookmarks by court group name",
            OperationId = "BookMarks.GetBookMarksByCourtGroupName",
            Tags = new[] { "BookMarks" }
        )]
        public override async Task<ActionResult<Result<IEnumerable<BookMarkDto>>>> HandleAsync(GetBookMarksByCourtGroupNameRequest request, CancellationToken cancellationToken = default)
        {
            var bookMarkParameters = new BookMarkParameters
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize
            };

            var result = await _mediator.Send(new GetBookMarksByCourtGroupNameQuery
            {
                CourtGroupName = request.CourtGroupName,
                BookMarkParameters = bookMarkParameters
            });

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

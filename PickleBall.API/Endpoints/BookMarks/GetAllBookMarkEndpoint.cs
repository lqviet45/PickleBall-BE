using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_BookMark.Queries.GetAllBookMark;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Paging;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.BookMarks
{
    public record GetAllBookMarkRequest
    {
        [FromQuery]
        public int PageNumber { get; set; } = 1;

        [FromQuery]
        public int PageSize { get; set; } = 10;
    }

    public class GetAllBookMarkEndpoint : EndpointBaseAsync.WithRequest<GetAllBookMarkRequest>.WithActionResult<Result<IEnumerable<BookMarkDto>>>
    {
        private readonly IMediator _mediator;

        public GetAllBookMarkEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/bookmarks")]
        [SwaggerOperation(
            Summary = "Get all bookmarks",
            Description = "Get all bookmarks",
            OperationId = "BookMarks.GetAllBookMark",
            Tags = new[] { "BookMarks" }
        )]
        public override async Task<ActionResult<Result<IEnumerable<BookMarkDto>>>> HandleAsync(GetAllBookMarkRequest request, CancellationToken cancellationToken = default)
        {
            var bookMarkParameters = new BookMarkParameters
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize
            };

            Result<IEnumerable<BookMarkDto>> result = await _mediator.Send(new GetAllBookMarkQuery
            {
                BookMarkParameters = bookMarkParameters,
            }, cancellationToken);

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

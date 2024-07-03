using System.Text.Json;
using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_BookMark.Queries.GetAllBookMarkByUserId;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Paging;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.BookMarks
{
    public record GetAllBookMarkRequestByUserId
    {
        [FromRoute]
        public Guid Id { get; set; }

        [FromQuery]
        public int PageNumber { get; set; } = 1;

        [FromQuery]
        public int PageSize { get; set; } = 10;
    }

    public class GetAllBookMarkByUserIdEndpoint
        : EndpointBaseAsync.WithRequest<GetAllBookMarkRequestByUserId>.WithActionResult<
            Result<IEnumerable<BookMarkDto>>
        >
    {
        private readonly IMediator _mediator;

        public GetAllBookMarkByUserIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/users/{Id}/bookmarks")]
        [SwaggerOperation(
            Summary = "Get all bookmarks by user id",
            Description = "Get all bookmarks by user id",
            OperationId = "BookMarks.GetAllBookMarkByUserId",
            Tags = new[] { "BookMarks" }
        )]
        public override async Task<ActionResult<Result<IEnumerable<BookMarkDto>>>> HandleAsync(
            GetAllBookMarkRequestByUserId request,
            CancellationToken cancellationToken = default
        )
        {
            var bookMarkParameters = new BookMarkParameters
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize
            };

            Result<PagedList<BookMarkDto>> result = await _mediator.Send(
                new GetAllBookMarkByUserIdQuery
                {
                    Id = request.Id,
                    BookMarkParameters = bookMarkParameters,
                },
                cancellationToken
            );

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            var pagedList = result.Value;

            Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedList.MetaData));

            return Ok(result);
        }
    }
}

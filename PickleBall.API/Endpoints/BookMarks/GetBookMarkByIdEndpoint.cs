using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_BookMark.Queries.GetBookMarkById;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Paging;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.BookMarks
{
    public record GetBookMarkByIdRequest
    {
        [FromRoute]
        public Guid Id { get; set; }

        [FromQuery]
        public int PageNumber { get; set; } = 1;

        [FromQuery]
        public int PageSize { get; set; } = 10;
    }

    public class GetBookMarkByIdEndpoint : EndpointBaseAsync.WithRequest<GetBookMarkByIdRequest>.WithActionResult<Result<BookMarkDto>>
    {
        private readonly IMediator _mediator;

        public GetBookMarkByIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/bookmarks/{Id}")]
        [SwaggerOperation(
            Summary = "Get bookmark by id",
            Description = "Get bookmark by id",
            OperationId = "BookMarks.GetBookMarkById",
            Tags = new[] { "BookMarks" }
        )]
        public override async Task<ActionResult<Result<BookMarkDto>>> HandleAsync(GetBookMarkByIdRequest request, CancellationToken cancellationToken = default)
        {
            var bookMarkParameters = new BookMarkParameters
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize
            };

            Result<BookMarkDto> result = await _mediator.Send(
                new GetBookMarkByIdQuery { Id = request.Id, BookMarkParameters = bookMarkParameters },
                cancellationToken);

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

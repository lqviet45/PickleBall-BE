using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_BookMark.Commands.CreateBookMark;
using PickleBall.Domain.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.BookMarks
{
    public record CreatBookMarkRequest
    {
        public Guid UserId { get; set; }
        public Guid CourtGroupId { get; set; }
    }

    public class CreatBookMarkEndpoint : EndpointBaseAsync.WithRequest<CreatBookMarkRequest>.WithActionResult<Result<BookMarkDto>>
    {
        private readonly IMediator _mediator;

        public CreatBookMarkEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("/api/bookmarks")]
        [SwaggerOperation(
            Summary = "Create a new bookmark",
            Description = "Create a new bookmark",
            OperationId = "BookMarks.CreateBookMark",
            Tags = new[] { "BookMarks" }
        )]
        public override async Task<ActionResult<Result<BookMarkDto>>> HandleAsync(CreatBookMarkRequest request, CancellationToken cancellationToken = default)
        {
            Result<BookMarkDto> result = await _mediator.Send(new CreateBookMarkCommand
            {
                UserId = request.UserId,
                CourtId = request.CourtGroupId
            });

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return result.IsSuccess ? Created(string.Empty, result) : BadRequest(result);
        }
    }
}

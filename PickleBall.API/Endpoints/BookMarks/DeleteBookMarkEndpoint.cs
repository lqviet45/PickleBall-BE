using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_BookMark.Commands.DeleteBookMark;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.BookMarks
{
    public record DeleteBookMarkRequest
    {
        [FromRoute]
        public Guid Id { get; set; }
    }

    public class DeleteBookMarkEndpoint
        : EndpointBaseAsync.WithRequest<DeleteBookMarkRequest>.WithActionResult
    {
        private readonly IMediator _mediator;

        public DeleteBookMarkEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpDelete]
        [Route("/api/bookmarks/{Id}")]
        [Authorize]
        [SwaggerOperation(
            Summary = "Delete a bookmark",
            Description = "Delete a bookmark",
            OperationId = "BookMarks.DeleteBookMark",
            Tags = new[] { "BookMarks" }
        )]
        public override async Task<ActionResult> HandleAsync(
            DeleteBookMarkRequest request,
            CancellationToken cancellationToken = default
        )
        {
            var result = await _mediator.Send(new DeleteBookMarkCommand { Id = request.Id });

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return NoContent();
        }
    }
}

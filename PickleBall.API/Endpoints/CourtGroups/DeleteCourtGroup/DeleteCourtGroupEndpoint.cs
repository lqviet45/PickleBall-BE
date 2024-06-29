using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_CourtGroup.Commands.DeleteCourtGroup;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.CourtGroups.DeleteCourtGroup
{
    public record DeleteCourtGroupRequest
    {
        [FromRoute]
        public Guid Id { get; set; }
    }

    public class DeleteCourtGroupEndpoint : EndpointBaseAsync.WithRequest<DeleteCourtGroupRequest>.WithActionResult
    {
        private readonly IMediator _mediator;

        public DeleteCourtGroupEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpDelete]
        [Route("/api/court-groups/{Id}")]
        [SwaggerOperation(
            Summary = "Deletes a CourtGroup",
            Description = "Deletes a CourtGroup",
            OperationId = "CourtGroups.Delete",
            Tags = new[] { "CourtGroups" }
        )]
        public override async Task<ActionResult> HandleAsync(DeleteCourtGroupRequest request, CancellationToken cancellationToken = default)
        {
            Result result = await _mediator.Send(new DeleteCourtGroupCommand { Id = request.Id }, cancellationToken);

            if (!result.IsSuccess)
            {
                return result.IsNotFound() ? NotFound(result.Errors) : BadRequest(result.Errors);
            }

            return NoContent();

        }
    }
}

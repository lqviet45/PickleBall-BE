using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_ApplicationUser.Commands.DeleteUser;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.ApplicationUser.DeleteUser
{
    public record DeleteUserRequest
    {
        [FromRoute]
        public Guid Id { get; init; }
    }

    public class DeleteUserEndpoint
        : EndpointBaseAsync.WithRequest<DeleteUserRequest>.WithActionResult
    {
        public readonly IMediator _mediator;

        public DeleteUserEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpDelete]
        [Route("/api/users/{Id}")]
        [Authorize]
        [SwaggerOperation(
            Summary = "Delete a user",
            Description = "Delete a user",
            OperationId = "ApplicationUser.DeleteUser",
            Tags = new[] { "ApplicationUser" }
        )]
        public override async Task<ActionResult> HandleAsync(
            DeleteUserRequest request,
            CancellationToken cancellationToken = default
        )
        {
            Result result = await _mediator.Send(
                new DeleteUserCommand { Id = request.Id },
                cancellationToken
            );

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return NoContent();
        }
    }
}

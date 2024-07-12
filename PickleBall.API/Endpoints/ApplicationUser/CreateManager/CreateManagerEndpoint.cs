using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_ApplicationUser.Commands.CreateManager;
using PickleBall.Domain.DTOs.ApplicationUserDtos;
using PickleBall.Domain.DTOs.Enum;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.ApplicationUser.CreateManager;

public class CreateManagerRequest
{
    [FromRoute]
    public required Guid OwnerId { get; init; }

    [FromBody]
    public required CreateManagerDto CreateManager { get; init; }
}

public class CreateManagerEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<CreateManagerRequest>.WithActionResult
{
    private readonly IMediator _mediator = mediator;

    [HttpPost]
    [Route("/api/users/{OwnerId}/managers")]
    [Authorize(Roles = "Owner")]
    [SwaggerOperation(
        Summary = "Create a new manager",
        Description = "Create a new manager",
        OperationId = "ApplicationUser.CreateManager",
        Tags = new[] { "ApplicationUser" }
    )]
    public override async Task<ActionResult> HandleAsync(
        [FromRoute] CreateManagerRequest request,
        CancellationToken cancellationToken = default
    )
    {
        var command = new CreateManagerCommand
        {
            OwnerId = request.OwnerId,
            Email = request.CreateManager.Email,
            Password = request.CreateManager.Password,
            FirstName = request.CreateManager.FirstName,
            LastName = request.CreateManager.LastName,
            Location = request.CreateManager.Location,
            Role = Role.Manager
        };

        Result<ApplicationUserDto> result = await _mediator.Send(command, cancellationToken);

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result) : BadRequest(result);

        return Created("", result);
    }
}

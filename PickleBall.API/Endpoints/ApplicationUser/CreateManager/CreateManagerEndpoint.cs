using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_ApplicationUser.Commands.CreateManager;
using PickleBall.Application.UseCases.UseCase_ApplicationUser.Commands.Register;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.DTOs.Enum;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.ApplicationUser.CreateManager;

public record CreateManagerRequest
{
    public Guid OwnerId { get; init; }
    public string? Email { get; init; }
    public string? Password { get; init; }
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public string? Location { get; init; }
}

public class CreateManagerEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<CreateManagerRequest>.WithActionResult
{
    private readonly IMediator _mediator = mediator;

    [HttpPost]
    [Route("/api/users")]
    [SwaggerOperation(
        Summary = "Create a new manager",
        Description = "Create a new manager",
        OperationId = "ApplicationUser.CreateManager",
        Tags = new[] { "ApplicationUser" }
    )]
    public override async Task<ActionResult> HandleAsync(
        CreateManagerRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Result<ApplicationUserDto> result = await _mediator.Send(
            new CreateManagerCommand
            {
                OwnerId = request.OwnerId,
                Email = request.Email,
                Password = request.Password,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Location = request.Location,
                Role = Role.Manager
            },
            cancellationToken
        );

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result) : BadRequest(result);

        return Created("", result);
    }
}

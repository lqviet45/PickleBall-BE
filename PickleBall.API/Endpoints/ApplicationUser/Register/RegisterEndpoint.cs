using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_ApplicationUser.Commands.Register;
using PickleBall.Domain.DTOs.ApplicationUserDtos;
using PickleBall.Domain.DTOs.Enum;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.ApplicationUser.Register;

public record RegisterApplicationUser
{
    public string? Email { get; init; }
    public string? Password { get; init; }
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public string? Location { get; init; }
    public Role Role { get; init; }
}

public class RegisterEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<RegisterApplicationUser>.WithActionResult
{
    private readonly IMediator _mediator = mediator;

    [HttpPost]
    [Route("/api/register")]
    [SwaggerOperation(
        Summary = "Register a new user",
        Description = "Register a new user",
        OperationId = "ApplicationUser.Register",
        Tags = new[] { "ApplicationUser" }
    )]
    public override async Task<ActionResult> HandleAsync(
        RegisterApplicationUser request,
        CancellationToken cancellationToken = default
    )
    {
        var command = new RegisterCommand(
            request.Email,
            request.Password,
            request.FirstName,
            request.LastName,
            request.Location,
            request.Role
        );

        Result<ApplicationUserDto> result = await _mediator.Send(command, cancellationToken);

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result) : BadRequest(result);

        return Created("", result);
    }
}

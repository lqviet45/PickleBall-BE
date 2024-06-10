using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_ApplicationUser.Commands.Register;
using PickleBall.Domain.DTOs;

namespace PickleBall.API.Endpoints.ApplicationUser.Register;

public record RegisterApplicationUser
{
    public string? Email { get; init; }
    public string? Password { get; init; }
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public string? FullName { get; init; }
    public string? Location { get; init; }
}

public class RegisterEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<RegisterApplicationUser>.WithActionResult
{
    private readonly IMediator _mediator = mediator;

    [HttpPost]
    [Route("/api/users")]
    public override async Task<ActionResult> HandleAsync(
        RegisterApplicationUser request,
        CancellationToken cancellationToken = default
    )
    {
        Result<ApplicationUserDTO> result = await _mediator.Send(
            new RegisterApplicationUserCommand(
                request.Email,
                request.Password,
                request.FirstName,
                request.LastName,
                request.FullName,
                request.Location
            ),
            cancellationToken
        );

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result) : BadRequest(result);

        return Created("", result);
    }
}

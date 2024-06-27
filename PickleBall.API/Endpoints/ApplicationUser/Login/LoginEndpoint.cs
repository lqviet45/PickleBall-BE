using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_ApplicationUser.Commands.Login;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.ApplicationUser.Login;

public class LoginEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<LoginCommand>.WithActionResult
{
    private readonly IMediator _mediator = mediator;

    [HttpPost]
    [Route("/api/login")]
    [SwaggerOperation(
        Summary = "Login",
        Description = "Login",
        OperationId = "ApplicationUser.Login",
        Tags = new[] { "ApplicationUser" }
    )]
    public override async Task<ActionResult> HandleAsync(
        LoginCommand command,
        CancellationToken cancellationToken = default
    )
    {
        return Ok(await _mediator.Send(command));
    }
}

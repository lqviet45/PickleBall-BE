using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetUserByEmail;
using PickleBall.Domain.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.ApplicationUser.GetUserByEmail;

public record GetUserByEmailRequest
{
    [FromQuery]
    public string? Email { get; set; }
};

public class GetUserByEmailEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<GetUserByEmailRequest>.WithActionResult<
        Result<ApplicationUserDto>
    >
{
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    [Route("/api/users/email")]
    [SwaggerOperation(
        Summary = "Get user by email",
        Description = "Get user by email",
        OperationId = "ApplicationUser.GetUserByEmail",
        Tags = new[] { "ApplicationUser" }
    )]
    public override async Task<ActionResult<Result<ApplicationUserDto>>> HandleAsync(
        GetUserByEmailRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Result<ApplicationUserDto> result = await _mediator.Send(
            new GetUserByEmailQuery { Email = request.Email },
            cancellationToken
        );

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result) : BadRequest(result);

        return Ok(result);
    }
}

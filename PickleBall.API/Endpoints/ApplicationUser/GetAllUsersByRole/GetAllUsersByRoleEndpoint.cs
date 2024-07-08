using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetAllUsersByRole;
using PickleBall.Domain.DTOs.Enum;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.ApplicationUser.GetAllUsersByRole;

public record GetAllUsersByRoleRequest
{
    [FromQuery]
    public Role Role { get; set; }
}

public class GetAllUsersByRoleEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<GetAllUsersByRoleRequest>.WithActionResult
{
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    [Route("/api/users/role")]
    [SwaggerOperation(
        Summary = "Get all users by role",
        Description = "Get all users by role",
        OperationId = "ApplicationUser.GetAllUsersByRole",
        Tags = new[] { "ApplicationUser" }
    )]
    public override async Task<ActionResult> HandleAsync(
        GetAllUsersByRoleRequest request,
        CancellationToken cancellationToken = default
    )
    {
        var query = new GetAllUsersByRoleQuery { Role = request.Role };

        var result = await _mediator.Send(query, cancellationToken);

        if (!result.IsSuccess)
            return BadRequest(result);

        return Ok(result);
    }
}

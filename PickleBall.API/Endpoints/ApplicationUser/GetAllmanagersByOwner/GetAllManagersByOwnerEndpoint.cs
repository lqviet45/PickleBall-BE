using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetAllManagerByOwner;
using PickleBall.Domain.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.ApplicationUser.GetAllmanagersByOwner;

public record GetAllManagersByOwnerRequest
{
    [FromRoute]
    public Guid Id { get; init; }
}

public class GetAllManagersByOwnerEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<GetAllManagersByOwnerRequest>.WithActionResult
{
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    [Route("api/users/{Id}/managers")]
    [SwaggerOperation(
        Summary = "Get all managers by owner",
        Description = "Get all managers by owner",
        OperationId = "ApplicationUser.GetAllManagersByOwner",
        Tags = new[] { "ApplicationUser" }
    )]
    public override async Task<ActionResult> HandleAsync(
        GetAllManagersByOwnerRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Result<IEnumerable<ApplicationUserDto>> result = await _mediator.Send(
            new GetAllManagersByOwnerQuery { Id = request.Id },
            cancellationToken
        );

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result) : BadRequest(result);

        return Ok(result);
    }
}

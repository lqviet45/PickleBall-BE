using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetUserById;
using PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetAllCourtGroupsByManagerId;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.DTOs.Enum;

namespace PickleBall.API.Endpoints.CourtGroups.GetAllCourtGroupsByManagerId;

public record GetCourtGroupsByManagerIdRequest
{
    [FromRoute]
    public Guid ManagerId { get; set; }
}

public class GetAllCourtGroupsByManagerIdEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<GetCourtGroupsByManagerIdRequest>.WithActionResult<
        Result<IEnumerable<CourtGroupDto>>
    >
{
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    [Route("/api/court-groups/manager/{ManagerId}")]
    public override async Task<ActionResult<Result<IEnumerable<CourtGroupDto>>>> HandleAsync(
        GetCourtGroupsByManagerIdRequest request,
        CancellationToken cancellationToken = default
    )
    {
        var user = await GetUserAndCheckRoleAsync(request.ManagerId, cancellationToken);

        if (!user.IsSuccess)
            return user.IsNotFound() ? NotFound(user) : Unauthorized(user);

        Result<IEnumerable<CourtGroupDto>> result = await _mediator.Send(
            new GetAllCourtGroupsByManagerIdQuery { ManagerId = request.ManagerId },
            cancellationToken
        );

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result) : BadRequest(result);

        return Ok(result);
    }

    private async Task<Result<ApplicationUserDto>> GetUserAndCheckRoleAsync(
        Guid id,
        CancellationToken cancellationToken = default
    )
    {
        var user = await _mediator.Send(new GetUserByIdQuery { Id = id }, cancellationToken);

        if (!user.IsSuccess)
            return Result.NotFound("User is not found");

        if (user.Value.Role != Role.Manager)
            return Result.Unauthorized();

        return user;
    }
}

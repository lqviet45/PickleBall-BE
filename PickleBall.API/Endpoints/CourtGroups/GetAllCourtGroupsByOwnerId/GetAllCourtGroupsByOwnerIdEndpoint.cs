using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetUserById;
using PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetAllCourtGroupsByOwnerId;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.DTOs.Enum;

namespace PickleBall.API.Endpoints.CourtGroups.GetAllCourtGroupsByOwnerId;

public record GetCourtGroupsByOwnerIdRequest
{
    [FromRoute]
    public Guid UserId { get; set; }
}

public class GetAllCourtGroupsByOwnerIdEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<GetCourtGroupsByOwnerIdRequest>.WithActionResult<
        Result<IEnumerable<CourtGroupDto>>
    >
{
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    [Route("/api/users/{UserId}/court-groups")]
    public override async Task<ActionResult<Result<IEnumerable<CourtGroupDto>>>> HandleAsync(
        GetCourtGroupsByOwnerIdRequest request,
        CancellationToken cancellationToken = default
    )
    {
        var user = await GetUserAndCheckRoleAsync(request.UserId, cancellationToken);

        if (!user.IsSuccess)
            return user.IsNotFound() ? NotFound(user) : Unauthorized(user);

        Result<IEnumerable<CourtGroupDto>> result = await _mediator.Send(
            new GetAllCourtGroupsByOwnerIdQuery { OwnerId = request.UserId },
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

        if (user.Value.Role != Role.Owner)
            return Result.Unauthorized();

        return user;
    }
}

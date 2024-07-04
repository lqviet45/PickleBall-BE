using System.Text.Json;
using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetUserById;
using PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetAllCourtGroupsByOwnerId;
using PickleBall.Domain.DTOs.ApplicationUserDtos;
using PickleBall.Domain.DTOs.CourtGroupsDtos;
using PickleBall.Domain.DTOs.Enum;
using PickleBall.Domain.Paging;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.CourtGroups.GetAllCourtGroupsByOwnerId;

public record GetCourtGroupsByOwnerIdRequest
{
    [FromRoute]
    public Guid UserId { get; set; }

    [FromQuery]
    public int PageNumber { get; set; } = 1;

    [FromQuery]
    public int PageSize { get; set; } = 10;
}

public class GetAllCourtGroupsByOwnerIdEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<GetCourtGroupsByOwnerIdRequest>.WithActionResult<
        Result<IEnumerable<CourtGroupDto>>
    >
{
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    [Route("/api/users/{UserId}/court-groups")]
    [SwaggerOperation(
        Summary = "Get all court groups by owner",
        Description = "Get all court groups by owner",
        OperationId = "CourtGroups.GetAllCourtGroupsByOwnerId",
        Tags = new[] { "CourtGroups" }
    )]
    public override async Task<ActionResult<Result<IEnumerable<CourtGroupDto>>>> HandleAsync(
        GetCourtGroupsByOwnerIdRequest request,
        CancellationToken cancellationToken = default
    )
    {
        var user = await GetUserAndCheckRoleAsync(request.UserId, cancellationToken);

        if (!user.IsSuccess)
            return user.IsNotFound() ? NotFound(user) : Unauthorized(user);

        var courtGroupParameters = new CourtGroupParameters
        {
            PageNumber = request.PageNumber,
            PageSize = request.PageSize
        };

        Result<PagedList<CourtGroupDto>> result = await _mediator.Send(
            new GetAllCourtGroupsByOwnerIdQuery
            {
                OwnerId = request.UserId,
                CourtGroupParameters = courtGroupParameters
            },
            cancellationToken
        );

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result) : BadRequest(result);

        // var pagedList = result.Value;

        // Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedList.MetaData));

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

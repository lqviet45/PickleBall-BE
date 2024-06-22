using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetUserById;
using PickleBall.Application.UseCases.UseCase_CourtGroup.Commands.CreateCourtGroup;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.DTOs.Enum;

namespace PickleBall.API.Endpoints.CourtGroups.CreateCourtGroupByOwnerId
{
    public record CreateCourtGroupRequest
    {
        [FromRoute]
        public Guid UserId { get; set; }

        [FromQuery]
        public string WardName { get; set; }

        [FromQuery]
        public Guid WalletId { get; set; }

        [FromQuery]
        public string? Name { get; set; }

        [FromQuery]
        public decimal Price { get; set; }

        [FromQuery]
        public int MinSlots { get; set; }

        [FromQuery]
        public int MaxSlots { get; set; }
    }

    public class CreateCourtGroupByOwnerId
        : EndpointBaseAsync.WithRequest<CreateCourtGroupRequest>.WithActionResult<CourtGroupDto>
    {
        private readonly IMediator _mediator;

        public CreateCourtGroupByOwnerId(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("/api/users/{UserId}/court-groups")]
        public override async Task<ActionResult<CourtGroupDto>> HandleAsync(
            CreateCourtGroupRequest request,
            CancellationToken cancellationToken = default
        )
        {
            var user = await GetUserAndCheckRoleAsync(request.UserId, cancellationToken);

            if (!user.IsSuccess)
                return user.IsNotFound() ? NotFound(user) : Unauthorized(user);

            Result<CourtGroupDto> result = await _mediator.Send(
                new CreateCourtGroupCommand
                {
                    UserId = request.UserId,
                    WardName = request.WardName,
                    WalletId = request.WalletId,
                    Name = request.Name,
                    Price = request.Price,
                    MinSlots = request.MinSlots,
                },
                cancellationToken
            );

            if (!result.IsSuccess)
                return BadRequest(result);

            return Created("Created successfully!", result);
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
}

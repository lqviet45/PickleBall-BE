using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetUserById;
using PickleBall.Application.UseCases.UseCase_CourtGroup.Commands.CreateCourtGroup;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.DTOs.Enum;
using System.ComponentModel.DataAnnotations;

namespace PickleBall.API.Endpoints.CourtGroups.CreateCourtGroupByOwnerId
{
    public record CreateCourtGroupRequest
    {
        [Url]
        public string? MediaUrl { get; set; } = string.Empty;
        [Required]
        public Guid UserId { get; set; }
        public string? WardName { get; set; } = string.Empty;
        [Required]
        public string? Name { get; set; } = string.Empty;
        [Required]
        [RegularExpression(@"^[0-9]*\.?[0-9]+$", ErrorMessage = "Price must be a valid decimal number.")]
        public decimal Price { get; set; }
        public int MinSlots { get; set; }
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
        [Route("/api/court-groups")]
        public override async Task<ActionResult<CourtGroupDto>> HandleAsync(
            CreateCourtGroupRequest request,
            CancellationToken cancellationToken = default
        )
        {
            var user = await GetUserAndCheckRoleAsync(request.UserId, cancellationToken);

            if (!user.IsSuccess)
                return user.IsNotFound() ? NotFound(user) : Unauthorized(user);

            if (request.MinSlots > request.MaxSlots)
                return BadRequest("MinSlots must be less than or equal to MaxSlots");

            Result<CourtGroupDto> result = await _mediator.Send(
                new CreateCourtGroupCommand
                {
                    UserId = request.UserId,
                    WardName = request.WardName,
                    MediaUrl = request.MediaUrl,
                    Name = request.Name,
                    Price = request.Price,
                    MinSlots = request.MinSlots,
                    MaxSlots = request.MaxSlots
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

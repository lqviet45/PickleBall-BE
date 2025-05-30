﻿using System.ComponentModel.DataAnnotations;
using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetUserById;
using PickleBall.Application.UseCases.UseCase_CourtGroup.Commands.CreateCourtGroup;
using PickleBall.Domain.DTOs.ApplicationUserDtos;
using PickleBall.Domain.DTOs.CourtGroupsDtos;
using PickleBall.Domain.DTOs.Enum;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.CourtGroups.CreateCourtGroupByOwnerId
{
    public record CreateCourtGroupRequest
    {
        [Url]
        public string? MediaUrl { get; set; } = null;

        [Required]
        public Guid UserId { get; set; }
        public string? WardName { get; set; } = string.Empty;

        [Required]
        public string? Name { get; set; } = string.Empty;

        [Required]
        [Range(
            0,
            double.MaxValue,
            ErrorMessage = "Price must be a valid decimal number greater than or equal to 0."
        )]
        public decimal Price { get; set; }

        [Required]
        [Range(
            0,
            int.MaxValue,
            ErrorMessage = "MinSlots must be an integer greater than or equal to 0."
        )]
        public int MinSlots { get; set; }

        [Required]
        [Range(
            0,
            int.MaxValue,
            ErrorMessage = "MaxSlots must be an integer greater than or equal to 0."
        )]
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
        [Authorize(Roles = "Owner")]
        [SwaggerOperation(
            Summary = "Create a new court group",
            Description = "Create a new court group by the owner",
            OperationId = "CourtGroups.CreateCourtGroupByOwnerId",
            Tags = new[] { "CourtGroups" }
        )]
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

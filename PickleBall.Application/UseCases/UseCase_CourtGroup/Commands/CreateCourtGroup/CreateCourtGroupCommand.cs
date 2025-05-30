﻿using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.CourtGroupsDtos;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Commands.CreateCourtGroup
{
    public class CreateCourtGroupCommand : IRequest<Result<CourtGroupDto>>
    {
        public Guid UserId { get; set; }
        public string? WardName { get; set; } = string.Empty;
        public string? Name { get; set; } = string.Empty;
        public string? MediaUrl { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int MinSlots { get; set; }
        public int MaxSlots { get; set; }
    }
}

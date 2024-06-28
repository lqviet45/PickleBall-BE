using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Commands.UpdateUser;

public sealed record UpdateUserCommand(
    Guid Id,
    string? Email,
    string? FirstName,
    string? LastName,
    string? Location,
    string? PhoneNumber,
    DateTime? DayOfBirth
) : IRequest<Result<ApplicationUserDto>>;

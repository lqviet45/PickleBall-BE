using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.ApplicationUserDtos;
using PickleBall.Domain.DTOs.Enum;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Commands.Register;

public record RegisterCommand(
    string? Email,
    string? Password,
    string? FirstName,
    string? LastName,
    string? Location,
    Role Role
) : IRequest<Result<ApplicationUserDto>>;

public record RegisterRequest(string Email, string Password);

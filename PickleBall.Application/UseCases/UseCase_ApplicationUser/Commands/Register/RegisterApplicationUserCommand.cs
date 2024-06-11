using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.DTOs.Enum;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Commands.Register;

public record RegisterApplicationUserCommand(
    string Email,
    string Password,
    string FirstName,
    string LastName,
    string FullName,
    string Location,
    Role Role
) : IRequest<Result<ApplicationUserDto>>;

public record RegisterApplicationUserRequest(string Email, string Password);

using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Commands.Register;

public record RegisterApplicationUserCommand(
    string Email,
    string Password,
    string FirstName,
    string LastName,
    string FullName,
    string Location
) : IRequest<Result<ApplicationUserDTO>>;

public record RegisterApplicationUserRequest(string Email, string Password);

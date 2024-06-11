using MediatR;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Commands.Login;

public record LoginCommand(string Email, string Password) : IRequest<string>;

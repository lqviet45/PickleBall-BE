using MediatR;
using PickleBall.Application.UseCases.Abstraction;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Commands.Login;

internal sealed class LoginHandler(IJwtProvider jwtProvider) : IRequestHandler<LoginCommand, string>
{
    private readonly IJwtProvider _jwtProvider = jwtProvider;

    public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        return await _jwtProvider.GetForCredentialsAsync(request.Email, request.Password);
    }
}

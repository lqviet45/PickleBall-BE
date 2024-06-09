using Ardalis.Result;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Commands.Register;

internal sealed class RegisterApplicationUserHandler(
    IAuthenticationService authenticationService,
    IUnitOfWork unitOfWork
) : IRequestHandler<RegisterApplicationUserCommand, Result<ApplicationUserDTO>>
{
    private readonly IAuthenticationService _authenticationService = authenticationService;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<Result<ApplicationUserDTO>> Handle(
        RegisterApplicationUserCommand request,
        CancellationToken cancellationToken
    )
    {
        var identityId = await _authenticationService.Register(request.Email, request.Password);

        var user = new ApplicationUser
        {
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName,
            FullName = request.FullName,
            Location = request.Location,
            IdentityId = identityId
        };

        _unitOfWork.RepositoryApplicationUser.AddAsync(user);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        // Set custom claims
        var claims = new Dictionary<string, object>
        {
            { "FullName", user.FullName },
            { "Location", user.Location }
        };
        await _authenticationService.SetCustomClaims(identityId, claims);

        return Result.Success(
            new ApplicationUserDTO
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                FullName = user.FullName,
                Location = user.Location,
                IdentityId = user.IdentityId
            }
        );
    }
}

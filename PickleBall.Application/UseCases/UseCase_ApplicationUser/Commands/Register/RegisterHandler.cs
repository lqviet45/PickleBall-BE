using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.DTOs.Enum;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Commands.Register;

internal sealed class RegisterHandler(
    IAuthenticationService authenticationService,
    IUnitOfWork unitOfWork,
    IMapper mapper
) : IRequestHandler<RegisterCommand, Result<ApplicationUserDto>>
{
    private readonly IAuthenticationService _authenticationService = authenticationService;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task<Result<ApplicationUserDto>> Handle(
        RegisterCommand request,
        CancellationToken cancellationToken
    )
    {
        ApplicationUserDto userDto = await AddUserToFirebase(request);

        await SetCustomClaim(userDto);

        await AddUserToDB(userDto, cancellationToken);

        return Result.Success(userDto);
    }

    private async Task<ApplicationUserDto> AddUserToFirebase(RegisterCommand request)
    {
        var identityId = await _authenticationService.Register(request.Email, request.Password);

        return new ApplicationUserDto
        {
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName,
            FullName = request.FullName,
            Location = request.Location,
            IdentityId = identityId,
            Role = request.Role
        };
    }

    private async Task SetCustomClaim(ApplicationUserDto userDto)
    {
        if (userDto.IdentityId != null)
        {
            string role = GetUserRole(userDto);
            var claims = new Dictionary<string, object> { { "Role", role } };
            await _authenticationService.SetCustomClaims(userDto.IdentityId, claims);
        }
    }

    private string GetUserRole(ApplicationUserDto userDto)
    {
        return userDto.Role switch
        {
            Role.SystemAdmin => Role.SystemAdmin.ToString(),
            Role.Manager => Role.Manager.ToString(),
            Role.Owner => Role.Owner.ToString(),
            _ => Role.Customer.ToString(), // or any other default value that makes sense in your application
        };
    }

    private async Task AddUserToDB(ApplicationUserDto userDto, CancellationToken cancellationToken)
    {
        ApplicationUser user = _mapper.Map<ApplicationUserDto, ApplicationUser>(userDto);

        _unitOfWork.RepositoryApplicationUser.AddAsync(user);

        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}

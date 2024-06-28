using Ardalis.Result;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Commands.UpdateUser;

public sealed class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Result<ApplicationUserDto>>
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IMapper _mapper;

    public UpdateUserCommandHandler(UserManager<ApplicationUser> userManager, IMapper mapper)
    {
        _userManager = userManager;
        _mapper = mapper;
    }

    public async Task<Result<ApplicationUserDto>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByIdAsync(request.Id.ToString());
        
        if (user == null)
            return Result<ApplicationUserDto>.NotFound();
        
        user.Email = request.Email ?? user.Email;
        user.FirstName = request.FirstName ?? user.FirstName;
        user.LastName = request.LastName ?? user.LastName;
        user.Location = request.Location ?? user.Location;
        user.PhoneNumber = request.PhoneNumber ?? user.PhoneNumber;
        user.DayOfBirth = request.DayOfBirth ?? user.DayOfBirth;
        
        var result = await _userManager.UpdateAsync(user);
        
        if (!result.Succeeded)
            return Result<ApplicationUserDto>.Error();

        var userResponse = _mapper.Map<ApplicationUserDto>(user);
        return Result<ApplicationUserDto>.Success(userResponse);
    }
}
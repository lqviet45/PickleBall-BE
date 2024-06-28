using MediatR;
using Microsoft.AspNetCore.Identity;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Commands.UpdateDeviceToken;

public sealed class UpdateDeviceTokenCommandHandler : IRequestHandler<UpdateDeviceTokenCommand, bool>
{
    private readonly UserManager<ApplicationUser> _userManager;

    public UpdateDeviceTokenCommandHandler(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<bool> Handle(UpdateDeviceTokenCommand request, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByIdAsync(request.UserId);
        if (user is null)
            return false;

        if (user.DeviceToken == request.DeviceToken) return true;
        
        user.DeviceToken = request.DeviceToken;
        await _userManager.UpdateAsync(user);
        
        return true;
    }
}
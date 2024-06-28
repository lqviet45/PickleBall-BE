using MediatR;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Commands.UpdateDeviceToken;

public sealed record UpdateDeviceTokenCommand(string UserId, string DeviceToken) : IRequest<bool>;
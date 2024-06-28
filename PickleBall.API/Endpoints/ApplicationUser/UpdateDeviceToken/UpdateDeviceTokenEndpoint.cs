using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_ApplicationUser.Commands.UpdateDeviceToken;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.ApplicationUser.UpdateDeviceToken;

public readonly record struct UpdateDeviceTokenRequest(Guid UserId, string DeviceToken);

public class UpdateDeviceTokenEndpoint : EndpointBaseAsync.WithRequest<UpdateDeviceTokenRequest>.WithActionResult<bool>
{
    private readonly ISender _sender;

    public UpdateDeviceTokenEndpoint(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost("/api/users/device-token")]
    [SwaggerOperation(
        Summary = "Change Device Token",
        Description = "Change Device Token for a user",
        OperationId = "ApplicationUser.UpdateDeviceToken",
        Tags = new[] { "ApplicationUser" }
    )]
    public override async Task<ActionResult<bool>> HandleAsync(UpdateDeviceTokenRequest request, CancellationToken cancellationToken = new CancellationToken())
    {
        var userCommand = new UpdateDeviceTokenCommand(request.UserId.ToString(), request.DeviceToken);
        var isSuccess = await _sender.Send(userCommand, cancellationToken);
        
        return Ok(isSuccess);
    }
}
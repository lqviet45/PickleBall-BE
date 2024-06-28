using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_ApplicationUser.Commands.UpdateUser;
using PickleBall.Domain.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.ApplicationUser.UpdateUser;

public readonly record struct UpdateUserRequest(
    Guid Id,
    string? Email,
    string? FirstName,
    string? LastName,
    string? Location,
    string? PhoneNumber,
    DateTime? DayOfBirth
);

public class UpdateUserEndpoint : EndpointBaseAsync.WithRequest<UpdateUserRequest>.WithResult<Result<ApplicationUserDto>>
{
    private readonly ISender _mediator;

    public UpdateUserEndpoint(ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpPut("/api/users/update-user")]
    [SwaggerOperation(
        Summary = "Update User",
        Description = "Update User Information",
        OperationId = "ApplicationUser.UpdateUser",
        Tags = new[] { "ApplicationUser" }
    )]
    public override async Task<Result<ApplicationUserDto>> HandleAsync(UpdateUserRequest request, CancellationToken cancellationToken = new CancellationToken())
    {
        var command = new UpdateUserCommand(
            request.Id,
            request.Email,
            request.FirstName,
            request.LastName,
            request.Location,
            request.PhoneNumber,
            request.DayOfBirth  
        );
        
        return await _mediator.Send(command, cancellationToken);
    }
}
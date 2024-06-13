using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetUserByFirebaseId;
using PickleBall.Domain.DTOs;

namespace PickleBall.API.Endpoints.ApplicationUser.GetUserByFirebaseId;

public record GetUserByFirebaseIdRequest(string FirebaseId);

public class GetUserByFirebaseIdEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<GetUserByFirebaseIdRequest>.WithActionResult<
        Result<ApplicationUserDto>
    >
{
    private readonly IMediator _mediator = mediator;

    [HttpPost]
    [Route("/api/users/firebase-id")]
    public override async Task<ActionResult<Result<ApplicationUserDto>>> HandleAsync(
        GetUserByFirebaseIdRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Result<ApplicationUserDto> result = await _mediator.Send(
            new GetUserByFirebaseIdQuery { FirebaseId = request.FirebaseId },
            cancellationToken
        );

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result) : BadRequest(result);

        return Ok(result);
    }
}

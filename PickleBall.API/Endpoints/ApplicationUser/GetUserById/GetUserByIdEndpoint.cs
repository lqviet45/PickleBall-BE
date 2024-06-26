using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetUserById;
using PickleBall.Domain.DTOs;

namespace PickleBall.API.Endpoints.ApplicationUser.GetUserById;

public record GetUserByIdRequest
{
    [FromRoute]
    public Guid Id { get; init; }
};

public class GetUserByIdEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<GetUserByIdRequest>.WithActionResult<ApplicationUserDto>
{
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    [Route("/api/users/{Id}")]
    public override async Task<ActionResult<ApplicationUserDto>> HandleAsync(
        GetUserByIdRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Result<ApplicationUserDto> result = await _mediator.Send(
            new GetUserByIdQuery { Id = request.Id },
            cancellationToken
        );

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result) : BadRequest(result);

        return Ok(result);
    }
}

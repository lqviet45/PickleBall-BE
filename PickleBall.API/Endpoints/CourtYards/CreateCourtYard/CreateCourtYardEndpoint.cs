using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_CourtYard.Commands.CreateCourtYardByCourtGroupId;
using PickleBall.Domain.DTOs.CourtYardDtos;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.CourtYards.CreateCourtYard;

public record CreateCourtYardRequest
{
    [FromRoute]
    public Guid CourtGroupId { get; set; }

    [FromBody]
    public string? Name { get; set; }
}

public class CreateCourtYardEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<CreateCourtYardRequest>.WithActionResult
{
    private readonly IMediator _mediator = mediator;

    [HttpPost]
    [Route("/api/court-groups/{CourtGroupId}/court-yards")]
    [Authorize(Roles = "Owner, Manager")]
    [SwaggerOperation(
        Summary = "Create a CourtYard",
        Description = "Create a CourtYard",
        OperationId = "CourtYard.Create",
        Tags = new[] { "CourtYards" }
    )]
    public override async Task<ActionResult> HandleAsync(
        CreateCourtYardRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Result<CourtYardDto> result = await _mediator.Send(
            new CreateCourtYardCommand { CourtGroupId = request.CourtGroupId, Name = request.Name },
            cancellationToken
        );

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result.Errors) : BadRequest(result.Errors);

        return Ok(result);
    }
}

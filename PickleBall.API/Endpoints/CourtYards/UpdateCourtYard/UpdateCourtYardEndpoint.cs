using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_CourtYard.Commands.UpdateCourtYard;
using PickleBall.Domain.DTOs.CourtYardDtos;
using PickleBall.Domain.Entities.Enums;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.CourtYards.UpdateCourtYard;

public record UpdateCourtYardRequest
{
    [FromRoute]
    public required Guid Id { get; init; }

    [FromBody]
    public required UpdateCourtYardDto UpdateCourtYard { get; init; }
}

public class UpdateCourtYardEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<UpdateCourtYardRequest>.WithActionResult
{
    private readonly IMediator _mediator = mediator;

    [HttpPut]
    [Route("/api/courtyards/{Id:guid}")]
    [Authorize(Roles = "Owner, Manager")]
    [SwaggerOperation(
        Summary = "Update a court yard",
        Description = "Update a court yard",
        OperationId = "CourtYard.Update",
        Tags = new[] { "CourtYards" }
    )]
    public override async Task<ActionResult> HandleAsync(
        UpdateCourtYardRequest request,
        CancellationToken cancellationToken = default
    )
    {
        var command = new UpdateCourtYardCommand
        {
            CourtYardId = request.Id,
            Name = request.UpdateCourtYard.Name,
            CourtYardStatus = request.UpdateCourtYard.CourtYardStatus,
            Type = request.UpdateCourtYard.Type
        };

        Result<CourtYardDto> result = await _mediator.Send(command, cancellationToken);

        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result) : BadRequest(result);

        return Ok(result);
    }
}

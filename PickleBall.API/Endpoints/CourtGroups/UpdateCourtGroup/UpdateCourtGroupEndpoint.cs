using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_CourtGroup.Commands.UpdateCourtGroup;
using PickleBall.Domain.DTOs.CourtGroupsDtos;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.CourtGroups.UpdateCourtGroup;

public record UpdateCourtGroupPriceRequest
{
    [FromRoute]
    public Guid Id { get; set; }

    [FromBody]
    public required UpdateCourtGroupDto UpdateCourtGroup { get; set; }
}

public class UpdateCourtGroupPriceEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<UpdateCourtGroupPriceRequest>.WithActionResult
{
    private readonly IMediator _mediator = mediator;

    [HttpPut]
    [Route("/api/court-groups/{Id}")]
    [Authorize(Roles = "Owner, Manager")]
    [SwaggerOperation(
        Summary = "Updates a Court Group",
        Description = "Updates a Court Group",
        OperationId = "CourtGroup.UpdateCourtGroup",
        Tags = new[] { "CourtGroups" }
    )]
    public override async Task<ActionResult> HandleAsync(
        UpdateCourtGroupPriceRequest request,
        CancellationToken cancellationToken = default
    )
    {
        var command = new UpdateCourtGroupCommand
        {
            Id = request.Id,
            Name = request.UpdateCourtGroup.Name,
            Price = request.UpdateCourtGroup.Price,
            MinSlots = request.UpdateCourtGroup.MinSlots,
            MaxSlots = request.UpdateCourtGroup.MaxSlots
        };

        Result<CourtGroupDto> result = await _mediator.Send(command, cancellationToken);

        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }
}

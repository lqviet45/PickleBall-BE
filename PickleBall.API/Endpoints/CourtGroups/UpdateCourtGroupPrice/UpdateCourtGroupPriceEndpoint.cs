using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_CourtGroup.Commands.UpdateCourtGroupPrice;
using PickleBall.Domain.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.CourtGroups.UpdateCourtGroupPrice;

public record UpdateCourtGroupPriceRequest
{
    [FromRoute]
    public Guid Id { get; set; }

    [FromBody]
    public decimal Price { get; set; }
}

public class UpdateCourtGroupPriceEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<UpdateCourtGroupPriceRequest>.WithActionResult
{
    private readonly IMediator _mediator = mediator;

    [HttpPut]
    [Route("/api/court-groups/{Id}/price")]
    [SwaggerOperation(
        Summary = "Updates a Court Group's Price",
        Description = "Updates a Court Group's Price",
        OperationId = "CourtGroup.UpdateCourtGroupPrice",
        Tags = new[] { "CourtGroups" }
    )]
    public override async Task<ActionResult> HandleAsync(
        UpdateCourtGroupPriceRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Result<CourtGroupDto> result = await _mediator.Send(
            new UpdateCourtGroupPriceCommand { Id = request.Id, Price = request.Price },
            cancellationToken
        );

        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }
}

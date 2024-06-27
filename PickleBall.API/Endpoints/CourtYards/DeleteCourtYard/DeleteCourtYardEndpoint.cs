using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_CourtYard.Commands.DeleteCourtYard;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.CourtYards.DeleteCourtYard;

public record DeleteCourtYardCommandRequest
{
    [FromRoute]
    public Guid Id { get; set; }
}

public class DeleteCourtYardEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<DeleteCourtYardCommandRequest>.WithActionResult
{
    private readonly IMediator _mediator = mediator;

    [HttpDelete]
    [Route("/api/court-yards/{Id}")]
    [SwaggerOperation(
        Summary = "Deletes a CourtYard",
        Description = "Deletes a CourtYard",
        OperationId = "CourtYard.Delete",
        Tags = new[] { "CourtYards" }
    )]
    public override async Task<ActionResult> HandleAsync(
        DeleteCourtYardCommandRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Result result = await _mediator.Send(
            new DeleteCourtYardCommand { Id = request.Id },
            cancellationToken
        );
        if (!result.IsSuccess)
            return result.IsNotFound() ? NotFound(result.Errors) : BadRequest(result.Errors);

        return NoContent();
    }
}

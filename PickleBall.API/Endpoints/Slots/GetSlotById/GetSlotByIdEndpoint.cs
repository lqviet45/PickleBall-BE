using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Slot.Queries.GetSlotById;
using PickleBall.Domain.DTOs;

namespace PickleBall.API.Endpoints.Slots.GetSlotById
{
    public record GetSlotByIdRequest
    {
        [FromRoute]
        public Guid Id { get; set; }
    }

    public class GetSlotByIdEndpoint : EndpointBaseAsync.WithRequest<GetSlotByIdRequest>.WithActionResult<Result<SlotDto>>
    {
        private readonly IMediator _mediator;

        public GetSlotByIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/slots/{Id}")]
        public override async Task<ActionResult<Result<SlotDto>>> HandleAsync(GetSlotByIdRequest request, CancellationToken cancellationToken = default)
        {
            Result<SlotDto> result = await _mediator.Send(new GetSlotByIdQuery { Id = request.Id }, cancellationToken);

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

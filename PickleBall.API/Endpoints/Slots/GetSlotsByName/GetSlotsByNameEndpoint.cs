using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Slot.Queries.GetSlotsByName;
using PickleBall.Domain.DTOs;

namespace PickleBall.API.Endpoints.Slots.GetSlotsByName
{
    public record GetSlotsByNameRequest
    {
        [FromQuery]
        public string Name { get; set; } = string.Empty;
    }

    public class GetSlotsByNameEndpoint : EndpointBaseAsync.WithRequest<GetSlotsByNameRequest>.WithActionResult<Result<IEnumerable<SlotDto>>>
    {
        private readonly IMediator _mediator;

        public GetSlotsByNameEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/slots/search")]
        public override async Task<ActionResult<Result<IEnumerable<SlotDto>>>> HandleAsync(GetSlotsByNameRequest request, CancellationToken cancellationToken = default)
        {
            Result<IEnumerable<SlotDto>> result = await _mediator.Send(new GetSlotsByNameQuery { Name = request.Name }, cancellationToken);

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

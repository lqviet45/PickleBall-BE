using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Ward.Queries.GetWardById;
using PickleBall.Domain.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Wards.GetWardById
{
    public record GetWardByIdRequest
    {
        [FromRoute]
        public Guid WardId { get; set; }
    }

    public class GetWardByIdEndpoint
        : EndpointBaseAsync.WithRequest<GetWardByIdRequest>.WithActionResult<Result<WardDto>>
    {
        private readonly IMediator _mediator;

        public GetWardByIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("api/wards/{WardId}")]
        [SwaggerOperation(
            Summary = "Get a ward by id",
            Description = "Get a ward by id",
            OperationId = "Wards.GetById",
            Tags = new[] { "Wards" }
        )]
        public override async Task<ActionResult<Result<WardDto>>> HandleAsync(
            GetWardByIdRequest request,
            CancellationToken cancellationToken = default
        )
        {
            Result<WardDto> wardDto = await _mediator.Send(
                new GetWardByIdQuery { Id = request.WardId, },
                cancellationToken
            );

            if (!wardDto.IsSuccess)
                return wardDto.IsNotFound() ? NotFound(wardDto) : BadRequest(wardDto);

            return Ok(wardDto);
        }
    }
}

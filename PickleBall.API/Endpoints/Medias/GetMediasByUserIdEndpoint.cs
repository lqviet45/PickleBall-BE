using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Media.Queries.GetMediasByUserId;
using PickleBall.Domain.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Medias
{
    public record GetMediasByUserIdRequest
    {
        [FromRoute]
        public Guid UserId { get; init; }
    }

    public class GetMediasByUserIdEndpoint
        : EndpointBaseAsync.WithRequest<GetMediasByUserIdRequest>.WithActionResult<
            Result<IEnumerable<MediaDto>>
        >
    {
        private readonly IMediator _mediator;

        public GetMediasByUserIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("api/users/{UserId}/medias")]
        [SwaggerOperation(
            Summary = "Get medias by user id",
            Description = "Get medias by user id",
            OperationId = "Medias.GetByUserId",
            Tags = new[] { "Medias" }
        )]
        public override async Task<ActionResult<Result<IEnumerable<MediaDto>>>> HandleAsync(
            GetMediasByUserIdRequest request,
            CancellationToken cancellationToken = default
        )
        {
            Result<IEnumerable<MediaDto>> result = await _mediator.Send(
                new GetMediasByUserIdQuery { UserId = request.UserId, },
                cancellationToken
            );

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

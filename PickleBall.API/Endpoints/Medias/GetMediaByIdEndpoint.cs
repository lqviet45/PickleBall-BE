using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Media.Queries.GetMediaById;
using PickleBall.Domain.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Medias
{
    public record GetMediaByIdRequest
    {
        [FromRoute]
        public Guid Id { get; init; }
    }

    public class GetMediaByIdEndpoint
        : EndpointBaseAsync.WithRequest<GetMediaByIdRequest>.WithActionResult<Result<MediaDto>>
    {
        private readonly IMediator _mediator;

        public GetMediaByIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/medias/{Id}")]
        [SwaggerOperation(
            Summary = "Get a media by id",
            Description = "Get a media by id",
            OperationId = "Medias.GetById",
            Tags = new[] { "Medias" }
        )]
        public override async Task<ActionResult<Result<MediaDto>>> HandleAsync(
            GetMediaByIdRequest request,
            CancellationToken cancellationToken = default
        )
        {
            Result<MediaDto> result = await _mediator.Send(
                new GetMediaByIdQuery { Id = request.Id },
                cancellationToken
            );

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

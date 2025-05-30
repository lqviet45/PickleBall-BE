﻿using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_BookMark.Queries.GetBookMarkById;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Paging;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.BookMarks
{
    public record GetBookMarkByIdRequest
    {
        [FromRoute]
        public Guid Id { get; set; }
    }

    public class GetBookMarkByIdEndpoint : EndpointBaseAsync.WithRequest<GetBookMarkByIdRequest>.WithActionResult<Result<BookMarkDto>>
    {
        private readonly IMediator _mediator;

        public GetBookMarkByIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/bookmarks/{Id}")]
        [SwaggerOperation(
            Summary = "Get bookmark by id",
            Description = "Get bookmark by id",
            OperationId = "BookMarks.GetBookMarkById",
            Tags = new[] { "BookMarks" }
        )]
        public override async Task<ActionResult<Result<BookMarkDto>>> HandleAsync(GetBookMarkByIdRequest request, CancellationToken cancellationToken = default)
        {
            Result<BookMarkDto> result = await _mediator.Send(
                new GetBookMarkByIdQuery { Id = request.Id },
                cancellationToken);

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

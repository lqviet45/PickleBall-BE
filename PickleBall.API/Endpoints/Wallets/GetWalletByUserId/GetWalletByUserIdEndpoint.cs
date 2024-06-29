using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Wallet.Queries;
using PickleBall.Domain.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Wallets.GetWalletByUserId
{
    public record GetWalletByUserIdRequest
    {
        [FromRoute]
        public Guid UserId { get; init; }
    }

    public class GetWalletByUserIdEndpoint : EndpointBaseAsync.WithRequest<GetWalletByUserIdRequest>.WithActionResult<Result<WalletDto>>
    {
        private readonly IMediator _mediator;

        public GetWalletByUserIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/wallets/{UserId}")]
        [SwaggerOperation(
            Summary = "Get a wallet by user id",
            Description = "Get a wallet by user id",
            OperationId = "Wallets.GetWalletByUserId",
            Tags = new[] { "Wallets" }
        )]
        public override async Task<ActionResult<Result<WalletDto>>> HandleAsync(GetWalletByUserIdRequest request, CancellationToken cancellationToken = default)
        {
            Result<WalletDto> result = await _mediator.Send(
                new GetWalletByUserIdQuery
                {
                    UserId = request.UserId
                },
                cancellationToken);

            if (!result.IsSuccess)
                return result.IsNotFound()
                    ? NotFound(result)
                    : BadRequest(result);

            return Ok(result);
        }
    }
}

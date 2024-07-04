using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetAllTransactionsByUserId;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Paging;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Transactions.GetAllTransactionsByUserId
{
    public record GetAllTransactionsByUserIdRequest
    {
        public Guid UserId { get; set; }

        [FromQuery]
        public int PageNumber { get; set; } = 1;

        [FromQuery]
        public int PageSize { get; set; } = 10;
    }

    public class GetAllTransactionsByUserIdEndpoint : EndpointBaseAsync.WithRequest<GetAllTransactionsByUserIdRequest>.WithActionResult
    {
        private readonly IMediator _mediator;

        public GetAllTransactionsByUserIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/users/{UserId}/transactions")]
        [SwaggerOperation(
            Summary = "Get all transactions by user id",
            Description = "Get all transactions by user id",
            OperationId = "Transactions.GetAllTransactionsByUserId",
            Tags = new[] { "Transactions" }
        )]
        public override async Task<ActionResult> HandleAsync(GetAllTransactionsByUserIdRequest request, CancellationToken cancellationToken = default)
        {
            var transactionsParameters = new TransactionParameters
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize
            };

            Result<PagedList<TransactionDto>> result = await _mediator.Send(
                               new GetAllTransactionsByUserIdQuery
                               {
                                   UserId = request.UserId,
                                   TransactionParameters = transactionsParameters
                               }, cancellationToken);

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

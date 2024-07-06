using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetAllTransactionsByCourtGroupId;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Paging;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Transactions.GetAllTransactionsByCourtGroupId
{
    public record GetAllTransactionsByCourtGroupIdRequest
    {
        [FromRoute]
        public Guid CourtGroupId { get; set; }

        [FromQuery]
        public int PageNumber { get; set; } = 1;

        [FromQuery]
        public int PageSize { get; set; } = 10;
    }

    public class GetAllTransactionsByCourtGroupIdEndpoint : EndpointBaseAsync.WithRequest<GetAllTransactionsByCourtGroupIdRequest>.WithActionResult
    {
        private readonly IMediator _mediator;

        public GetAllTransactionsByCourtGroupIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/court-groups/{CourtGroupId}/transactions")]
        [SwaggerOperation(
            Summary = "Get all transactions by court group id",
            Description = "Get all transactions by court group id",
            OperationId = "Transactions.GetAllTransactionsByCourtGroupId",
            Tags = new[] { "Transactions" }
        )]
        public override async Task<ActionResult> HandleAsync(GetAllTransactionsByCourtGroupIdRequest request, CancellationToken cancellationToken = default)
        {
            var transactionParameters = new TransactionParameters
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize
            };

            Result<PagedList<TransactionDto>> transactions = await _mediator.Send(
                               new GetAllTransactionsByCourtGroupIdQuery
                               {
                                   CourtGroupId = request.CourtGroupId,
                                   TransactionParameters = transactionParameters
                               },
                               cancellationToken);

            if (!transactions.IsSuccess)
                return transactions.IsNotFound() ? NotFound(transactions) : BadRequest(transactions);

            return Ok(transactions);
        }
    }
}

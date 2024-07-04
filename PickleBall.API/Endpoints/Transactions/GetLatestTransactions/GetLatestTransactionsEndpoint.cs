using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetLatestTransactions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Paging;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Transactions.GetLatestTransactions
{
    public record GetLatestTransactionsRequest
    {
        [FromQuery]
        public int PageNumber { get; set; } = 1;

        [FromQuery]
        public int PageSize { get; set; } = 10;
    }

    public class GetLatestTransactionsEndpoint : EndpointBaseAsync.WithRequest<GetLatestTransactionsRequest>.WithActionResult
    {
        private readonly IMediator _mediator;

        public GetLatestTransactionsEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/transactions")]
        [SwaggerOperation(
            Summary = "Get latest transactions",
            Description = "Get latest transactions",
            OperationId = "Transactions.GetLatestTransactions",
            Tags = new[] { "Transactions" }
        )]
        public override async Task<ActionResult> HandleAsync(GetLatestTransactionsRequest request, CancellationToken cancellationToken = default)
        {
            Result<PagedList<TransactionDto>> result = await _mediator.Send(
                               new GetLatestTransactionsQuery
                               {
                                   TransactionParameters = new TransactionParameters
                                   {
                                       PageNumber = request.PageNumber,
                                       PageSize = request.PageSize
                                   }
                               }, cancellationToken);

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

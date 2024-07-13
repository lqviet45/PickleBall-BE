using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetRevenueByCourtGroupId;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Transactions.GetRevenueByCourtGroupId
{
    public record GetRevenueByCourtGroupIdRequest
    {
        [FromRoute]
        public Guid CourtGroupId { get; init; }

        [FromQuery]
        public int Month { get; init; }

        [FromQuery]
        public int Year { get; init; }
    }

    public class GetRevenueByCourtGroupIdEndpoint : EndpointBaseAsync.WithRequest<GetRevenueByCourtGroupIdRequest>.WithActionResult
    {
        private readonly IMediator _mediator;

        public GetRevenueByCourtGroupIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/court-groups/{CourtGroupId}/revenues")]
        [Authorize(Roles = "Owner, SystemAdmin")]
        [SwaggerOperation(
           Summary = "Get revenue by court group id",
           Description = "Get revenue by court group id",
           OperationId = "Transaction.GetRevenueByCourtGroupId",
           Tags = new[] { "Transactions" }
        )]
        public override async Task<ActionResult> HandleAsync(GetRevenueByCourtGroupIdRequest request, CancellationToken cancellationToken = default)
        {
            var query = new GetRevenueByCourtGroupIdQuery
            {
                CourtGroupId = request.CourtGroupId,
                Month = request.Month,
                Year = request.Year
            };

            var result = await _mediator.Send(query, cancellationToken);

            return Ok(result);
        }
    }
}

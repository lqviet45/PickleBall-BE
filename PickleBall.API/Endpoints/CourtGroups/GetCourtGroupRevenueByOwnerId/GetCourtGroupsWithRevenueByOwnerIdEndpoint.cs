using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetCourtGroupsWithRevenueByOwnerId;
using PickleBall.Domain.Paging;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.CourtGroups.GetCourtGroupRevenueByOwnerId
{
    public record GetCourtGroupsWithRevenueByOwnerIdRequest
    {
        [FromRoute]
        public Guid OwnerId { get; set; }

        [FromQuery]
        public int Month { get; set; }

        [FromQuery]
        public int Year { get; set; }

        [FromQuery]
        public int PageNumber { get; set; } = 1;

        [FromQuery]
        public int PageSize { get; set; } = 10;
    }

    public class GetCourtGroupsWithRevenueByOwnerIdEndpoint
        : EndpointBaseAsync.WithRequest<GetCourtGroupsWithRevenueByOwnerIdRequest>.WithActionResult
    {
        private readonly IMediator _mediator;

        public GetCourtGroupsWithRevenueByOwnerIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/users/{OwnerId}/court-groups/revenue")]
        [Authorize(Roles = "Owner, SystemAdmin")]
        [SwaggerOperation(
            Summary = "Get all court groups with revenue by owner",
            Description = "Get all court groups with revenue by owner",
            OperationId = "CourtGroups.GetCourtGroupsWithRevenueByOwnerId",
            Tags = new[] { "CourtGroups" }
        )]
        public override async Task<ActionResult> HandleAsync(
            GetCourtGroupsWithRevenueByOwnerIdRequest request,
            CancellationToken cancellationToken = default
        )
        {
            var courtGroupParameters = new CourtGroupParameters
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize,
            };

            var result = await _mediator.Send(
                new GetCourtGroupsWithRevenueByOwnerIdQuery
                {
                    OwnerId = request.OwnerId,
                    Month = request.Month,
                    Year = request.Year,
                    CourtGroupParameters = courtGroupParameters
                },
                cancellationToken
            );

            if (!result.IsSuccess)
                return result.IsNotFound() ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
    }
}

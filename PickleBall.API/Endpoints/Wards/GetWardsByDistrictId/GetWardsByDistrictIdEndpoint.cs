using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Ward.Queries.GetWardsByDistrictId;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Paging;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Wards.GetWardsByDistrictId
{
    public record GetWardsByDistrictIdRequest
    {
        [FromRoute]
        public int DistrictId { get; set; }

        [FromQuery]
        public int PageNumber { get; set; } = 1;

        [FromQuery]
        public int PageSize { get; set; } = 10;
    }

    public class GetWardsByDistrictIdEndpoint : EndpointBaseAsync.WithRequest<GetWardsByDistrictIdRequest>.WithActionResult
    {
        private readonly IMediator _mediator;

        public GetWardsByDistrictIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/api/districts/{DistrictId}/wards")]
        [SwaggerOperation(
            Summary = "Get wards by district id",
            Description = "Get wards by district id",
            OperationId = "Wards.GetByDistrictId",
            Tags = new[] { "Wards" }
        )]
        public override async Task<ActionResult> HandleAsync(GetWardsByDistrictIdRequest request, CancellationToken cancellationToken = default)
        {
            var wardParameters = new WardParameters
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize
            };

            Result<PagedList<WardDto>> results = await _mediator.Send(
                               new GetWardsByDistrictIdQuery 
                               {
                                   DistrictId = request.DistrictId,
                                   WardParameters = wardParameters
                               },
                               cancellationToken);

            if (!results.IsSuccess)
                return results.IsNotFound() ? NotFound(results) : BadRequest(results);

            return Ok(results);
        }
    }
}

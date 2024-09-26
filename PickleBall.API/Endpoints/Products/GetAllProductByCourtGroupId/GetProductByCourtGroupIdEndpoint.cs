using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.Product.GetProduct;
using PickleBall.Domain.DTOs.Product;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Products.GetAllProductByCourtGroupId;

public class GetProductByCourtGroupIdEndpoint
    : EndpointBaseAsync.WithRequest<Guid>.WithActionResult
{
    private readonly ISender _sender;

    public GetProductByCourtGroupIdEndpoint(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    [Route("/api/court-groups/{courtGroupId:guid}/products")]
    [SwaggerOperation(
        Summary = "Get all Product in courtgroup",
        Description = "Get all Product in courtgroup",
        Tags = new[] { "Product" }
    )]
    public override async Task<ActionResult> HandleAsync([FromRoute] Guid courtGroupId , CancellationToken cancellationToken = new CancellationToken())
    {
        var request = new GetProductByCourtGroupIdQuery
        {
            CourtGroupId = courtGroupId
        };
        var result = await _sender.Send(request, cancellationToken);
        
        return result.IsSuccess
            ? Ok(result)
            : BadRequest(result);
    }
}
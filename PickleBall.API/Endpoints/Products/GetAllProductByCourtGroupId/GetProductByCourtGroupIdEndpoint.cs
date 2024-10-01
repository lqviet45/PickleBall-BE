using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.Product.GetProduct;
using PickleBall.Domain.DTOs.Product;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Products.GetAllProductByCourtGroupId;

public sealed class GetProductByCourtGroupId
{
    [FromRoute]
    public Guid CourtGroupId { get; set; }
    [FromQuery]
    public string Search { get; set; } = "";
}

public class GetProductByCourtGroupIdEndpoint
    : EndpointBaseAsync.WithRequest<GetProductByCourtGroupId>.WithActionResult
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
    public override async Task<ActionResult> HandleAsync(GetProductByCourtGroupId request,
        CancellationToken cancellationToken = new CancellationToken())
    {
        var getProductsQuery = new GetProductByCourtGroupIdQuery()
        {
            CourtGroupId = request.CourtGroupId,
            Search = request.Search
        };
        var result = await _sender.Send(getProductsQuery, cancellationToken);
        
        return result.IsSuccess
            ? Ok(result)
            : BadRequest(result);
    }
}
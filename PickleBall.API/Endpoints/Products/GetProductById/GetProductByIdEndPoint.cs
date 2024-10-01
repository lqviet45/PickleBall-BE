using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.Product.GetProduct;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Products.GetProductById;

public class GetProductByIdEndPoint : EndpointBaseAsync.WithRequest<Guid>.WithActionResult
{
    private readonly ISender _sender;

    public GetProductByIdEndPoint(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    [Route("/api/products/{id}")]
    [SwaggerOperation(
        Summary = "Get a Product by Id",
        Description = "Get a Product by Id",
        Tags = new[] { "Product" }
    )]
    public override async Task<ActionResult> HandleAsync(Guid id, CancellationToken cancellationToken = new CancellationToken())
    {
        var getProductQuery = new GetProductByIdQuery()
        {
            ProductId = id
        };
        var result = await _sender.Send(getProductQuery, cancellationToken);
        
        return result.IsSuccess
            ? Ok(result)
            : BadRequest(result);
    }
}
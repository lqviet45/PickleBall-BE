using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.Product.GetProduct;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Products.GetAllProduct;

public class GetAllProductEndPoint
    : EndpointBaseAsync.WithRequest<GetAllProductQuery>.WithActionResult
{
    private readonly ISender _sender;

    public GetAllProductEndPoint(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    [Route("/api/products")]
    [SwaggerOperation(
        Summary = "Get all Products",
        Description = "Get all Products",
        Tags = new[] { "Product" }
    )]
    public override async Task<ActionResult> HandleAsync([FromQuery] GetAllProductQuery request, CancellationToken cancellationToken = new CancellationToken())
    {
        var result = await _sender.Send(request, cancellationToken);
        
        return result.IsSuccess
            ? Ok(result)
            : BadRequest(result);
    }
}
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.Product.CreateProduct;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Products.CreateProduct;

public class CreateProductEndPoint
    : EndpointBaseAsync.WithRequest<CreateProductCommand>.WithActionResult
{
    private readonly ISender _sender;

    public CreateProductEndPoint(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost]
    [Route("/api/products")]
    [SwaggerOperation(
        Summary = "Create a new Product",
        Description = "Create a new Product",
        Tags = new[] { "Product" }
    )]
    public override async Task<ActionResult> HandleAsync(CreateProductCommand request, CancellationToken cancellationToken = new CancellationToken())
    {
        var result = await _sender.Send(request, cancellationToken);
        
        return result.IsSuccess
            ? Ok(result.Value)
            : BadRequest(result.Errors);
    }
}
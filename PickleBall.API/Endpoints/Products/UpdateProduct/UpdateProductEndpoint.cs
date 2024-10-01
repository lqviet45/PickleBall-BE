using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.Product.UpdateProduct;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Products.UpdateProduct;

public class UpdateProductEndpoint : EndpointBaseAsync.WithRequest<UpdateProductCommand>.WithActionResult
{
    private readonly ISender _sender;

    public UpdateProductEndpoint(ISender sender)
    {
        _sender = sender;
    }

    [HttpPut]
    [Route("/api/products/{id}")]
    [SwaggerOperation(
        Summary = "Update a Product",
        Description = "Update a Product",
        Tags = new[] { "Product" }
    )]
    public override async Task<ActionResult> HandleAsync(UpdateProductCommand request, CancellationToken cancellationToken = new CancellationToken())
    {
        var result = await _sender.Send(request, cancellationToken);
        
        return result.IsSuccess
            ? Ok(result.Value)
            : BadRequest(result.Errors);
    }
}
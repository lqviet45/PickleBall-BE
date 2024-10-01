using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.Payment.Commands.CreatePaymentForProduct;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Payment.CreateOrder;

public class CreatePaymentForProductEndPoint : EndpointBaseAsync.WithRequest<CreatePaymentForProductCommand>.WithActionResult
{
    private readonly ISender _sender;

    public CreatePaymentForProductEndPoint(ISender sender)
    {
        _sender = sender;
    }
    
    [HttpPost]
    [Route("/api/buy-product")]
    [SwaggerOperation(
        Summary = "Create a new Payment",
        Description = "Create a new Payment",
        Tags = new[] { "Payment" }
    )]
    public override async Task<ActionResult> HandleAsync(CreatePaymentForProductCommand request, CancellationToken cancellationToken = new CancellationToken())
    {
        var result = await _sender.Send(request, cancellationToken);
        
        return result.IsSuccess
            ? Ok(result.Value)
            : BadRequest(result.Errors);
    }
}
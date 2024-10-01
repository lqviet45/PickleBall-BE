using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.Payment.Commands.PaymentReturn;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Payment.PaymentReturn;

public class PaymentForProductReturnEndpoint 
    : EndpointBaseAsync.WithRequest<PaymentForProductReturnCommand>.WithActionResult
{
    private readonly ISender _sender;

    public PaymentForProductReturnEndpoint(ISender sender)
    {
        _sender = sender;
    }
    [HttpGet]
    [Route("/api/payment-product-return")]
    [SwaggerOperation(
        Summary = "Payment return link",
        Description = "Payment return link",
        Tags = new[] { "Order" }
    )]
    public override async Task<ActionResult> HandleAsync([FromQuery] PaymentForProductReturnCommand request, CancellationToken cancellationToken = new CancellationToken())
    {
        var result = await _sender.Send(request, cancellationToken);
        
        return result.IsSuccess ? Ok() : BadRequest();
    }
}
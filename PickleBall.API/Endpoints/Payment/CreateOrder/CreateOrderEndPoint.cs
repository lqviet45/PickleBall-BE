using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.Payment.Commands;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Payment.CreateOrder;

public class CreateOrderEndPoint 
    : EndpointBaseAsync.WithRequest<CreatePaymentCommand>.WithActionResult
{
    private readonly ISender _sender;

    public CreateOrderEndPoint(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost]
    [Route("/api/orders")]
    [SwaggerOperation(
        Summary = "Create a new order link",
        Description = "Create a new order",
        Tags = new[] { "Order" }
    )]
    public override async Task<ActionResult> HandleAsync(CreatePaymentCommand request, CancellationToken cancellationToken = new CancellationToken())
    {
        var result = await _sender.Send(request, cancellationToken);
        
        return result.IsSuccess
            ? Ok(result.Value)
            : BadRequest(result.Errors);
    }
}
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.Payment.Commands.PaymentReturn;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Payment.PaymentReturn;

public class PaymentReturnEndPoint 
    : EndpointBaseAsync.WithRequest<PaymentReturnUrl>.WithActionResult
{
    private readonly ISender _sender;

    public PaymentReturnEndPoint(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    [Route("/api/payment-return")]
    [SwaggerOperation(
        Summary = "Payment return link",
        Description = "Payment return link",
        Tags = new[] { "Order" }
    )]
    public override async Task<ActionResult> HandleAsync([FromQuery] PaymentReturnUrl request, CancellationToken cancellationToken = new CancellationToken())
    {
        var paymentReturnCommand = new PaymentReturnCommand()
        {
            Id = request.Id,
            Cancel = request.Cancel,
            Code = request.Code,
            OrderCode = request.OrderCode,
            Status = request.Status
        };

        var result = await _sender.Send(paymentReturnCommand, cancellationToken);

        return result.IsSuccess ? Ok() : BadRequest();
    }
}
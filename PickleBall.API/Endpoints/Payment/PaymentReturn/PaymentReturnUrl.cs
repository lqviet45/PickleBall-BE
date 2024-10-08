using MediatR;

namespace PickleBall.API.Endpoints.Payment.PaymentReturn;

public class PaymentReturnUrl
{
    public string? Code { get; set; }
    public string? Id { get; set; }
    public bool Cancel { get; set; }
    public string? Status { get; set; }
    public long OrderCode { get; set; }
    public Guid CustomerId { get; set; }
}
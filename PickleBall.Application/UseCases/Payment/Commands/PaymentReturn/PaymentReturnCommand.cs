using Ardalis.Result;
using MediatR;

namespace PickleBall.Application.UseCases.Payment.Commands.PaymentReturn;

public class PaymentReturnCommand : IRequest<Result>
{
    public string? Code { get; set; }
    public string? Id { get; set; }
    public bool Cancel { get; set; }
    public string? Status { get; set; }
    public long OrderCode { get; set; }
    public Guid CustomerId { get; set; }
}
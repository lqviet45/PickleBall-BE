using Ardalis.Result;
using MediatR;
using Net.payOS.Types;

namespace PickleBall.Application.UseCases.Payment.Commands.CreatePaymentForProduct;

public class CreatePaymentForProductCommand : IRequest<Result<CreatePaymentResult>>
{
    public Guid UserId { get; set; }
    public Guid CourtGroupId { get; set; }
    public string? Description { get; set; }
    public List<ProductBuyRequest> Products { get; set; } = [];
    public string? ReturnUrl { get; set; }
    public string? CancelUrl { get; set; }
}

public class ProductBuyRequest
{
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
}
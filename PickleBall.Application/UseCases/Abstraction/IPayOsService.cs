using Net.payOS.Types;
using PickleBall.Contract.Models;

namespace PickleBall.Application.UseCases.Abstraction;

public interface IPayOsService
{
    Task<CreatePaymentResult> CreatePayment(
        int totalAmount,
        List<PaymentItem> paymentItems,
        string returnUrl,
        string cancelUrl,
        string description = "",
        long orderCode = 0
    );
}
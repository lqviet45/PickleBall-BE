using Microsoft.Extensions.Configuration;
using Net.payOS;
using Net.payOS.Types;
using PickleBall.Application.UseCases.Abstraction;
using PickleBall.Contract.Models;

namespace PickleBall.Infrastructure.Services.Payment;

public class PayOSPayment : IPayOsService
{
    private readonly IConfiguration _configuration;

    public PayOSPayment(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<CreatePaymentResult> CreatePayment(
        int totalAmount, 
        List<PaymentItem> paymentItems,
        string returnUrl,
        string cancelUrl,
        string description = ""
    )
    {
        var clientId = _configuration["PayOS:ClientId"] ?? throw new ArgumentNullException("ClientId is required");
        var apiKey = _configuration["PayOS:ApiKey"] ?? throw new ArgumentNullException("ApiKey is required");
        var checkSumKey = _configuration["PayOS:CheckSumKey"] ?? throw new ArgumentNullException("CheckSumKey is required");
        // Create payment
        var orderCode = int.Parse(DateTimeOffset.Now.ToString("ffffff"));
        
        var items = paymentItems
            .Select(item => new ItemData(item.Name, item.Quantity, item.Price))
            .ToList();
        
        var payOS = new PayOS(clientId, apiKey, checkSumKey);
        var paymentData = new PaymentData(
            orderCode,
            totalAmount,
            description,
            items,
            returnUrl,
            cancelUrl
        );
        
        return await payOS.createPaymentLink(paymentData);
    }
}
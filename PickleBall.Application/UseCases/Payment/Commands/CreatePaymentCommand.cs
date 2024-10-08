using Ardalis.Result;
using MediatR;
using Net.payOS.Types;

namespace PickleBall.Application.UseCases.Payment.Commands;

public record CreatePaymentCommand(
    Guid userId,
    Guid bookingId,
    string name,
    string description,
    int price,
    string returnUrl,
    string cancelUrl
) : IRequest<Result<CreatePaymentResult>>;
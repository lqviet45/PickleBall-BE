using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Commands.CreateTransactionByBooking;

public class CreateTransactionByBookingCommand : IRequest<Result<TransactionDto>>
{
    public Guid UserId { get; set; }
    public Guid WalletId { get; set; }
    public Guid BookingId { get; set; }
    public Guid CourtGroupId { get; set; }
    public string? Description { get; set; }
}

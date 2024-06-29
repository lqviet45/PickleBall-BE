using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Commands.CreateTransactionByBooking;

public class CreateTransactionByBookingCommand : IRequest<Result>
{
    public Wallet? UserWallet { get; set; }
    public Wallet? OwnerWallet { get; set; }
    public CourtGroup? CourtGroup { get; set; }
    public Guid BookingId { get; set; }
    public string? Description { get; set; }
}

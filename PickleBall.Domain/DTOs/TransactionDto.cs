using PickleBall.Domain.DTOs.ApplicationUserDtos;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Domain.DTOs;

public class TransactionDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid WalletId { get; set; }
    public Guid DepositId { get; set; }
    public TransactionStatus TransactionStatus { get; set; }
    public decimal Amount { get; set; }
    public string? Description { get; set; }
    public Guid BookingId { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
}

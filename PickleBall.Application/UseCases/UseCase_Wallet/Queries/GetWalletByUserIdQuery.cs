using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Wallet.Queries
{
    public class GetWalletByUserIdQuery : IRequest<Result<WalletDto>>
    {
        public Guid UserId { get; set; }
        public bool TrackChanges { get; set; } = false;
    }
}

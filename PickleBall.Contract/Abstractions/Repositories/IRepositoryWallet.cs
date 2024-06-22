using PickleBall.Domain.Entities;

namespace PickleBall.Contract.Abstractions.Repositories
{
    public interface IRepositoryWallet : IRepositoryBase<Wallet>
    {
        public Task<Wallet?> GetWalletByIdAsync(
            Guid walletId,
            bool trackChanges,
            CancellationToken cancellationToken = default
        );
    }
}

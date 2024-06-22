using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.Data.Repositories
{
    internal sealed class RepositoryWallet : RepositoryBase<Wallet>, IRepositoryWallet
    {
        public RepositoryWallet(ApplicationDbContext context)
            : base(context) { }

        public Task<Wallet?> GetWalletByIdAsync(
            Guid walletId,
            bool trackChanges,
            CancellationToken cancellationToken = default
        ) => GetEntityByConditionAsync(w => w.Id == walletId, trackChanges, cancellationToken);
    }
}

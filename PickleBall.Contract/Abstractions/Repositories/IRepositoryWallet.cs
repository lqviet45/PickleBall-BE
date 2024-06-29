using System.Linq.Expressions;
using PickleBall.Domain.Entities;

namespace PickleBall.Contract.Abstractions.Repositories
{
    public interface IRepositoryWallet : IRepositoryBase<Wallet>
    {
        public Task<Wallet?> GetWalletByConditionAsync(
            Expression<Func<Wallet, bool>> expression,
            bool trackChanges,
            CancellationToken cancellationToken = default
        );
    }
}

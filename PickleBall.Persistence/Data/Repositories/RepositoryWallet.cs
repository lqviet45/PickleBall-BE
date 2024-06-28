using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Persistence.Data.Repositories
{
    internal sealed class RepositoryWallet(ApplicationDbContext context)
        : RepositoryBase<Wallet>(context),
            IRepositoryWallet
    {
        public Task<Wallet?> GetWalletByConditionAsync(
            Expression<Func<Wallet, bool>> expression,
            bool trackChanges,
            CancellationToken cancellationToken = default
        ) => GetEntityByConditionAsync(expression, trackChanges, cancellationToken);
    }
}

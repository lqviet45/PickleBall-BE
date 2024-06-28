using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.Data.Repositories;

internal sealed class RepositoryApplicationUser(ApplicationDbContext context)
    : RepositoryBase<ApplicationUser>(context),
        IRepositoryApplicationUser
{
    public async Task<ApplicationUser?> GetUserByConditionAsync(
        Expression<Func<ApplicationUser, bool>> expression,
        bool trackChanges,
        CancellationToken cancellationToken = default
    ) =>
        await GetEntityByConditionAsync(
            expression,
            trackChanges,
            cancellationToken,
            query => query.Include(u => u.Medias)
        );
}

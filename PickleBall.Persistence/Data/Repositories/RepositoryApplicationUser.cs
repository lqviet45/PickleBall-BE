using Microsoft.EntityFrameworkCore;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.Data.Repositories;

internal sealed class RepositoryApplicationUser(ApplicationDbContext context)
    : RepositoryBase<ApplicationUser>(context),
        IRepositoryApplicationUser
{
    public async Task<ApplicationUser?> GetUserByIdAsync(
        Guid id,
        bool trackChanges,
        CancellationToken cancellationToken = default
    ) =>
        await GetEntityByConditionAsync(
            u => u.Id == id,
            trackChanges,
            cancellationToken,
            query => query.Include(u => u.Medias)
        );

    public async Task<ApplicationUser?> GetUserByFirebaseIdAsync(
        string firebaseId,
        CancellationToken cancellationToken = default
    ) =>
        await GetEntityByConditionAsync(
            user => user.IdentityId == firebaseId,
            trackChanges: false,
            cancellationToken,
            query => query.Include(user => user.Medias)
        );

    public async Task<ApplicationUser?> GetUserByEmailAsync(
        string email,
        bool trackChanges,
        CancellationToken cancellationToken = default
    ) =>
        await GetEntityByConditionAsync(
            user => user.Email == email,
            trackChanges: false,
            cancellationToken,
            query => query.Include(user => user.Medias)
        );
}

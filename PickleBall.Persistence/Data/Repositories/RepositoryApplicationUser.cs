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
    ) => await GetEntityByConditionAsync(u => u.Id == id, trackChanges, cancellationToken);

    public async Task<ApplicationUser?> GetUserByFirebaseIdAsync(
        string firebaseId,
        CancellationToken cancellationToken = default
    )
    {
        ApplicationUser? user = await _context
            .Users.AsNoTracking()
            .FirstOrDefaultAsync(u => u.IdentityId == firebaseId);

        return user;
    }
}

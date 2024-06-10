using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.Data.Repositories;

public class RepositoryApplicationUser(ApplicationDbContext context)
    : RepositoryBase<ApplicationUser>(context),
        IRepositoryApplicationUser
{
    public Task<ApplicationUser> GetUserByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default
    )
    {
        throw new NotImplementedException();
    }
}

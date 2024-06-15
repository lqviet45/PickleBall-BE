using PickleBall.Domain.Entities;

namespace PickleBall.Contract.Abstractions.Repositories;

public interface IRepositoryApplicationUser : IRepositoryBase<ApplicationUser>
{
    Task<ApplicationUser?> GetUserByIdAsync(
        Guid id,
        bool trackChanges,
        CancellationToken cancellationToken = default
    );

    Task<ApplicationUser?> GetUserByFirebaseIdAsync(
        string firebaseId,
        CancellationToken cancellationToken = default
    );
}

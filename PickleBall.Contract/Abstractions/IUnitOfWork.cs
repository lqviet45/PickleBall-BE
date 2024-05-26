using PickleBall.Contract.Abstractions.Repositories;

namespace PickleBall.Application.Abstractions;

public interface IUnitOfWork
{
    IRepositoryCourtGroup RepositoryCourtGroup { get; }

    Task SaveChangesAsync(CancellationToken cancellationToken);
}

using PickleBall.Contract.Abstractions.Repositories;

namespace PickleBall.Application.Abstractions;

public interface IUnitOfWork
{
    IRepositoryCity RepositoryCity { get; }
    IRepositoryCourtGroup RepositoryCourtGroup { get; }

    Task SaveChangesAsync(CancellationToken cancellationToken);
}

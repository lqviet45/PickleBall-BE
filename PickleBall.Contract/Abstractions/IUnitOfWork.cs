using PickleBall.Contract.Abstractions.Repositories;

namespace PickleBall.Application.Abstractions;

public interface IUnitOfWork
{
    IRepositoryApplicationUser RepositoryApplicationUser { get; }
    IRepositoryCity RepositoryCity { get; }
    IRepositoryCourtGroup RepositoryCourtGroup { get; }
    IRepositoryCourtYard RepositoryCourtYard { get; }
    IRepositoryDistrict RepositoryDistrict { get; }

    Task SaveChangesAsync(CancellationToken cancellationToken);
}

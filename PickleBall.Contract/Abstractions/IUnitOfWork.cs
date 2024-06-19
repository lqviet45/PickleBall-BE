using PickleBall.Contract.Abstractions.Repositories;

namespace PickleBall.Application.Abstractions;

public interface IUnitOfWork
{
    IRepositoryApplicationUser RepositoryApplicationUser { get; }
    IRepositoryBooking RepositoryBooking { get; }
    IRepositoryCity RepositoryCity { get; }
    IRepositoryCourtGroup RepositoryCourtGroup { get; }
    IRepositoryCourtYard RepositoryCourtYard { get; }
    IRepositoryDate RepositoryDate { get; }
    IRepositoryDistrict RepositoryDistrict { get; }

    Task SaveChangesAsync(CancellationToken cancellationToken);
}

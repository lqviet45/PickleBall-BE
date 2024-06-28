using PickleBall.Contract.Abstractions.Repositories;

namespace PickleBall.Application.Abstractions;

public interface IUnitOfWork
{
    IRepositoryApplicationUser RepositoryApplicationUser { get; }
    IRepositoryBooking RepositoryBooking { get; }
    IRepositoryCity RepositoryCity { get; }
    IRepositoryCost RepositoryCost { get; }
    IRepositoryCourtGroup RepositoryCourtGroup { get; }
    IRepositoryCourtYard RepositoryCourtYard { get; }
    IRepositoryDate RepositoryDate { get; }
    IRepositoryDistrict RepositoryDistrict { get; }
    IRepositorySlot RepositorySlot { get; }
    IRepositorySlotBooking RepositorySlotBooking { get; }
    IRepositoryTransaction RepositoryTransaction { get; }
    IRepositoryWallet RepositoryWallet { get; }
    IRepositoryWard RepositoryWard { get; }
    IRepositoryMedia RepositoryMedia { get; }
    IRepositoryBookMark RepositoryBookMark { get; }

    Task SaveChangesAsync(CancellationToken cancellationToken);
}

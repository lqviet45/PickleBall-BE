using Microsoft.EntityFrameworkCore.Storage;
using PickleBall.Application.Abstractions;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Infrastructure.Data.Repositories;
using PickleBall.Persistence.Data.Repositories;

namespace PickleBall.Persistence.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly IDbContextTransaction _transaction;

        private readonly Lazy<IRepositoryApplicationUser> _repositoryApplicationUser;
        private readonly Lazy<IRepositoryBooking> _repositoryBooking;
        private readonly Lazy<IRepositoryCity> _repositoryCity;
        private readonly Lazy<IRepositoryCost> _repositoryCost;
        private readonly Lazy<IRepositoryCourtGroup> _repositoryCourtGroup;
        private readonly Lazy<IRepositoryCourtYard> _repositoryCourtYard;
        private readonly Lazy<IRepositoryDate> _repositoryDate;
        private readonly Lazy<IRepositoryDistrict> _repositoryDistrict;
        private readonly Lazy<IRepositorySlot> _repositorySlot;
        private readonly Lazy<IRepositorySlotBooking> _repositorySlotBooking;
        private readonly Lazy<IRepositoryTransaction> _repositoryTransaction;
        private readonly Lazy<IRepositoryWallet> _repositoryWallet;
        private readonly Lazy<IRepositoryWard> _repositoryWard;
        private readonly Lazy<IRepositoryMedia> _repositoryMedia;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            _transaction = _context.Database.BeginTransaction();

            _repositoryApplicationUser = new Lazy<IRepositoryApplicationUser>(
                () => new RepositoryApplicationUser(context)
            );
            _repositoryBooking = new Lazy<IRepositoryBooking>(() => new RepositoryBooking(context));
            _repositoryCity = new Lazy<IRepositoryCity>(() => new RepositoryCity(context));
            _repositoryCost = new Lazy<IRepositoryCost>(() => new RepositoryCost(context));
            _repositoryCourtGroup = new Lazy<IRepositoryCourtGroup>(
                () => new RepositoryCourtGroup(context)
            );
            _repositoryCourtYard = new Lazy<IRepositoryCourtYard>(
                () => new RepositoryCourtYard(context)
            );
            _repositoryDate = new Lazy<IRepositoryDate>(() => new RepositoryDate(context));
            _repositoryDistrict = new Lazy<IRepositoryDistrict>(
                () => new RepositoryDistrict(context)
            );
            _repositorySlot = new Lazy<IRepositorySlot>(() => new RepositorySlot(context));
            _repositorySlotBooking = new Lazy<IRepositorySlotBooking>(
                () => new RepositorySlotBooking(context)
            );
            _repositoryTransaction = new Lazy<IRepositoryTransaction>(
                () => new RepositoryTransaction(context)
            );
            _repositoryWallet = new Lazy<IRepositoryWallet>(() => new RepositoryWallet(context));
            _repositoryWard = new Lazy<IRepositoryWard>(() => new RepositoryWard(context));
            _repositoryMedia = new Lazy<IRepositoryMedia>(() => new RepositoryMedia(context));
        }

        public IRepositoryApplicationUser RepositoryApplicationUser =>
            _repositoryApplicationUser.Value;

        public IRepositoryBooking RepositoryBooking => _repositoryBooking.Value;

        public IRepositoryCity RepositoryCity => _repositoryCity.Value;

        public IRepositoryCost RepositoryCost => _repositoryCost.Value;

        public IRepositoryCourtGroup RepositoryCourtGroup => _repositoryCourtGroup.Value;

        public IRepositoryCourtYard RepositoryCourtYard => _repositoryCourtYard.Value;

        public IRepositoryDate RepositoryDate => _repositoryDate.Value;

        public IRepositoryDistrict RepositoryDistrict => _repositoryDistrict.Value;

        public IRepositorySlot RepositorySlot => _repositorySlot.Value;

        public IRepositorySlotBooking RepositorySlotBooking => _repositorySlotBooking.Value;

        public IRepositoryTransaction RepositoryTransaction => _repositoryTransaction.Value;

        public IRepositoryWallet RepositoryWallet => _repositoryWallet.Value;

        public IRepositoryWard RepositoryWard => _repositoryWard.Value;

        public IRepositoryMedia RepositoryMedia => _repositoryMedia.Value;

        public async Task SaveChangesAsync(CancellationToken cancellationToken)
        {
            try
            {
                await _context.SaveChangesAsync(cancellationToken);
                await _transaction.CommitAsync(cancellationToken);
            }
            catch
            {
                await _transaction.RollbackAsync(cancellationToken);
                throw;
            }
            finally
            {
                _transaction.Dispose();
            }
        }
    }
}

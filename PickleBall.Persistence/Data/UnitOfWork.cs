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
        private readonly Lazy<IRepositoryCourtGroup> _repositoryCourtGroup;
        private readonly Lazy<IRepositoryCourtYard> _repositoryCourtYard;
        private readonly Lazy<IRepositoryDate> _repositoryDate;
        private readonly Lazy<IRepositoryDistrict> _repositoryDistrict;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            _transaction = _context.Database.BeginTransaction();

            _repositoryApplicationUser = new Lazy<IRepositoryApplicationUser>(
                () => new RepositoryApplicationUser(context)
            );
            _repositoryBooking = new Lazy<IRepositoryBooking>(() => new RepositoryBooking(context));
            _repositoryCity = new Lazy<IRepositoryCity>(() => new RepositoryCity(context));
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
        }

        public IRepositoryApplicationUser RepositoryApplicationUser =>
            _repositoryApplicationUser.Value;

        public IRepositoryBooking RepositoryBooking => _repositoryBooking.Value;

        public IRepositoryCity RepositoryCity => _repositoryCity.Value;

        public IRepositoryCourtGroup RepositoryCourtGroup => _repositoryCourtGroup.Value;

        public IRepositoryCourtYard RepositoryCourtYard => _repositoryCourtYard.Value;

        public IRepositoryDate RepositoryDate => _repositoryDate.Value;

        public IRepositoryDistrict RepositoryDistrict => _repositoryDistrict.Value;

        public async Task SaveChangesAsync(CancellationToken cancellationToken) =>
            await _context.SaveChangesAsync(cancellationToken);
    }
}

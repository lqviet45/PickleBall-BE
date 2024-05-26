using Microsoft.EntityFrameworkCore.Storage;
using PickleBall.Application.Abstractions;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Infrastructure.Data.Repositories;

namespace PickleBall.Persistence.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly IDbContextTransaction _transaction;
        private readonly Lazy<IRepositoryCourtGroup> _repositoryCourtGroup;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            _transaction = _context.Database.BeginTransaction();

            _repositoryCourtGroup = new Lazy<IRepositoryCourtGroup>(
                () => new RepositoryCourtGroup(context)
            );
        }

        public IRepositoryCourtGroup RepositoryCourtGroup => _repositoryCourtGroup.Value;

        public async Task SaveChangesAsync(CancellationToken cancellationToken)
        {
            try
            {
                await _context.SaveChangesAsync();
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.Data.Repositories
{
    internal sealed class RepositoryWard : RepositoryBase<Ward>, IRepositoryWard
    {
        public RepositoryWard(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Ward?> GetUniqueWardByNameAsync(
                       string? name,
                       bool trackChanges,
                       CancellationToken cancellationToken = default)
            => trackChanges
            ? await _context.Wards.Where(w => w.Name == name).SingleOrDefaultAsync(cancellationToken)
            : await _context.Wards.AsNoTracking().Where(w => w.Name == name).SingleOrDefaultAsync(cancellationToken);
    }
}

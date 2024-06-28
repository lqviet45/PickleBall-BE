using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PickleBall.Contract.Abstractions.Repositories;

namespace PickleBall.Persistence.Data.Repositories;

public class RepositoryBase<T>(ApplicationDbContext context) : IRepositoryBase<T>
    where T : class
{
    protected readonly ApplicationDbContext _context = context;
    protected readonly DbSet<T> _dbSet = context.Set<T>();

    public void AddAsync(T entity) => _dbSet.Add(entity);

    public void UpdateAsync(T entity) => _dbSet.Update(entity);

    public void DeleteAsync(T entity)
    {
        var entityEntry = _dbSet.Update(entity);
        entityEntry.Property("IsDeleted").CurrentValue = true;
    }

    public async Task<IEnumerable<T>> GetAllAsync(
        bool trackChanges,
        CancellationToken cancellationToken = default,
        Func<IQueryable<T>, IQueryable<T>>? includeProperties = null
    )
    {
        IQueryable<T> query = trackChanges ? _dbSet : _dbSet.AsNoTracking();

        if (includeProperties != null)
            query = includeProperties(query);

        return await query.ToListAsync(cancellationToken);
    }

    public async Task<IEnumerable<T>> GetEntitiesByConditionAsync(
        Expression<Func<T, bool>> expression,
        bool trackChanges,
        CancellationToken cancellationToken = default,
        Func<IQueryable<T>, IQueryable<T>>? includeProperties = null
    )
    {
        IQueryable<T> query = trackChanges
            ? _dbSet.Where(expression)
            : _dbSet.AsNoTracking().Where(expression);

        if (includeProperties != null)
            query = includeProperties(query);

        return await query.ToListAsync(cancellationToken);
    }

    public Task<T?> GetEntityByConditionAsync(
        Expression<Func<T, bool>> expression,
        bool trackChanges,
        CancellationToken cancellationToken = default,
        Func<IQueryable<T>, IQueryable<T>>? includeProperties = null
    )
    {
        IQueryable<T> query = trackChanges ? _dbSet : _dbSet.AsNoTracking();

        if (includeProperties != null)
            query = includeProperties(query);

        return query.FirstOrDefaultAsync(expression, cancellationToken);
    }
}

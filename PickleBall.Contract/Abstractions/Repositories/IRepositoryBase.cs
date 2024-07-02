using System.Linq.Expressions;

namespace PickleBall.Contract.Abstractions.Repositories;

public interface IRepositoryBase<T>
    where T : class
{
    void AddAsync(T entity);
    void UpdateAsync(T entity);
    void DeleteAsync(T entity);
    Task DeleteRange(IEnumerable<T> entities);

    Task<IEnumerable<T>> GetAllAsync(
        bool trackChanges,
        CancellationToken cancellationToken = default,
        Func<IQueryable<T>, IQueryable<T>>? includeProperties = null
    );
    Task<IEnumerable<T>> GetEntitiesByConditionAsync(
        Expression<Func<T, bool>> expression,
        bool trackChanges,
        CancellationToken cancellationToken = default,
        Func<IQueryable<T>, IQueryable<T>>? includeProperties = null
    );
    Task<T?> GetEntityByConditionAsync(
        Expression<Func<T, bool>> expression,
        bool trackChanges,
        CancellationToken cancellationToken = default,
        Func<IQueryable<T>, IQueryable<T>>? includeProperties = null
    );
}

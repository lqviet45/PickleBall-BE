using System.Linq.Expressions;

namespace PickleBall.Contract.Abstractions.Repositories;

public interface IRepositoryBase<T>
    where T : class
{
    void AddAsync(T entity);
    void UpdateAsync(T entity);
    void DeleteAsync(T entity);

    Task<IEnumerable<T>> GetAllAsync(
        bool trackChanges,
        CancellationToken cancellationToken = default
    );
    Task<IEnumerable<T>> GetEntitiesByConditionAsync(
        Expression<Func<T, bool>> expression,
        bool trackChanges,
        CancellationToken cancellationToken = default
    );
    Task<T?> GetEntityByConditionAsync(
        Expression<Func<T, bool>> expression,
        bool trackChanges,
        CancellationToken cancellationToken = default
    );
}

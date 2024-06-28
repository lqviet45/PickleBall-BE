using System.Linq.Expressions;
using PickleBall.Domain.Entities;

namespace PickleBall.Contract.Abstractions.Repositories;

public interface IRepositoryApplicationUser : IRepositoryBase<ApplicationUser>
{
    Task<ApplicationUser?> GetUserByConditionAsync(
        Expression<Func<ApplicationUser, bool>> expression,
        bool trackChanges,
        CancellationToken cancellationToken = default
    );

    Task<IEnumerable<ApplicationUser>> GetAllUsersByConditionAsync(
        Expression<Func<ApplicationUser, bool>> expression,
        bool trackChanges,
        CancellationToken cancellationToken = default
    );
}

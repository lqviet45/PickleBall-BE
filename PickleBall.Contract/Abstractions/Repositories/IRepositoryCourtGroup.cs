using System.Linq.Expressions;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Paging;

namespace PickleBall.Contract.Abstractions.Repositories;

public interface IRepositoryCourtGroup : IRepositoryBase<CourtGroup>
{
    Task<IEnumerable<CourtGroup>> GetAllCourtGroupsAsync(
        bool trackChanges,
        CourtGroupParameters courtGroupParameters,
        CancellationToken cancellationToken = default
    );

    Task<IEnumerable<CourtGroup>> GetAllCourtGroupsByConditionAsync(
        Expression<Func<CourtGroup, bool>> conditions,
        bool trackChanges,
        CourtGroupParameters courtGroupParameters,
        CancellationToken cancellationToken = default
    );

    Task<CourtGroup?> GetCourtGroupByConditionAsync(
        Expression<Func<CourtGroup, bool>> conditions,
        bool trackChanges,
        CancellationToken cancellationToken = default
    );
}

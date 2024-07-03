using System.Linq.Expressions;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Paging;

namespace PickleBall.Contract.Abstractions.Repositories;

public interface IRepositoryCourtYard : IRepositoryBase<CourtYard>
{
    Task<IEnumerable<CourtYard>> GetAllByConditionAsync(
        Expression<Func<CourtYard, bool>> conditions,
        bool trackChanges,
        CourtYardParameters courtYardParameters,
        CancellationToken cancellationToken
    );

    Task<CourtYard?> GetCourtYardByIdAsync(
        Guid id,
        bool trackChanges,
        CancellationToken cancellationToken
    );
}

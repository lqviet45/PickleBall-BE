using PickleBall.Domain.Entities;
using PickleBall.Domain.Paging;
using System.Linq.Expressions;

namespace PickleBall.Contract.Abstractions.Repositories
{
    public interface IRepositoryBookMark : IRepositoryBase<BookMark>
    {
        Task<BookMark?> GetBookMarkByConditionAsync(
            Expression<Func<BookMark, bool>> conditions,
            bool trackChanges,
            BookMarkParameters bookMarkParameters,
            CancellationToken cancellationToken = default);

        Task<IEnumerable<BookMark>> GetAllBookMarksAsync(
            bool trackChanges,
            BookMarkParameters bookMarkParameters,
            CancellationToken cancellationToken = default);

        Task<IEnumerable<BookMark>> GetAllBookMarksByConditionAsync(
            Expression<Func<BookMark, bool>> conditions,
            bool trackChanges,
            BookMarkParameters bookMarkParameters,
            CancellationToken cancellationToken = default);
    }
}

using Microsoft.EntityFrameworkCore;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Paging;
using System.Linq.Expressions;

namespace PickleBall.Persistence.Data.Repositories
{
    internal class RepositoryBookMark : RepositoryBase<BookMark>, IRepositoryBookMark
    {
        public RepositoryBookMark(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<BookMark>> GetAllBookMarksAsync(bool trackChanges, BookMarkParameters bookMarkParameters, CancellationToken cancellationToken = default)
        =>
            await GetAllAsync(
            trackChanges,
            cancellationToken,
            query =>
                query
                    .Include(c => c.CourtGroup)
                    .Include(c => c.User)
                    .Skip((bookMarkParameters.PageNumber - 1) * bookMarkParameters.PageSize)
                    .Take(bookMarkParameters.PageSize)
            );

        public async Task<IEnumerable<BookMark>> GetAllBookMarksByConditionAsync(Expression<Func<BookMark, bool>> conditions, bool trackChanges, BookMarkParameters bookMarkParameters, CancellationToken cancellationToken = default)
        =>
            await GetEntitiesByConditionAsync(
            conditions,
            trackChanges,
            cancellationToken,
            query =>
                query
                    .Include(c => c.CourtGroup)
                    .Include(c => c.User)
                    .Skip((bookMarkParameters.PageNumber - 1) * bookMarkParameters.PageSize)
                    .Take(bookMarkParameters.PageSize)
            );

        public async Task<BookMark?> GetBookMarkByConditionAsync(Expression<Func<BookMark, bool>> conditions, bool trackChanges, CancellationToken cancellationToken = default)
        =>
            await GetEntityByConditionAsync(
            conditions,
            trackChanges,
            cancellationToken,
            query =>
                query
                    .Include(c => c.CourtGroup)
                    .Include(c => c.User)
                    .IgnoreQueryFilters()
            );
    }
}

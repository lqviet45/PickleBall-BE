using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.Data.Repositories
{
    internal class RepositoryBookMark : RepositoryBase<BookMark>, IRepositoryBookMark
    {
        public RepositoryBookMark(ApplicationDbContext context) : base(context)
        {
        }
    }
}

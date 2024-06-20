using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.Data.Repositories;

internal sealed class RepositoryDate(ApplicationDbContext context)
    : RepositoryBase<Date>(context),
        IRepositoryDate { }

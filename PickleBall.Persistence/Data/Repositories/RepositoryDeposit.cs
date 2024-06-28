using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.Data.Repositories;

internal sealed class RepositoryDeposit(ApplicationDbContext context)
    : RepositoryBase<Deposit>(context),
        IRepositoryDeposit { }

using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.Data.Repositories;

public class RepositoryTransaction(ApplicationDbContext context)
    : RepositoryBase<Transaction>(context),
        IRepositoryTransaction { }

using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.Data.Repositories;

public class RepositoryCost(ApplicationDbContext context)
    : RepositoryBase<Cost>(context),
        IRepositoryCost { }

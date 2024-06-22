using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.Data.Repositories;

public class RepositoryWallet(ApplicationDbContext context)
    : RepositoryBase<Wallet>(context),
        IRepositoryWallet { }

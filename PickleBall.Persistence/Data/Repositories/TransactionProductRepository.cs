using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.Data.Repositories;

public class TransactionProductRepository(ApplicationDbContext context) : RepositoryBase<TransactionProduct>(context), ITransactionProductRepository
{
    
}
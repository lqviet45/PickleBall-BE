using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.Data.Repositories;

public class ProductRepository(ApplicationDbContext context) : RepositoryBase<Product>(context), IProductRepository
{
}
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.Data.Repositories;

public class RepositorySlotBooking(ApplicationDbContext context)
    : RepositoryBase<SlotBooking>(context),
        IRepositorySlotBooking { }

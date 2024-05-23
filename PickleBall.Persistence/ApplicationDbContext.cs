using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        Console.WriteLine("OnModelCreating");
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);
    }

    public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }

    public virtual DbSet<Ward> Wards { get; set; }

    public virtual DbSet<CourtGroup> CourtGroups { get; set; }

    public virtual DbSet<CourtYard> CourtYards { get; set; }

    public virtual DbSet<Wallet> Wallets { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<Deposit> Deposits { get; set; }

    public virtual DbSet<District> Districts { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Media> Media { get; set; }

    public virtual DbSet<BookMark> BookMarks { get; set; }

    public virtual DbSet<Cost> Costs { get; set; }

    public virtual DbSet<Slot> Slots { get; set; }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<SlotBooking> SlotBookings { get; set; }
}
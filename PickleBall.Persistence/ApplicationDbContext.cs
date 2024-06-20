using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using PickleBall.Domain.Entities;
using PickleBall.Persistence.FakeDataGenerator;

namespace PickleBall.Persistence;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        Console.WriteLine("OnModelCreating");
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);

        // ApplicationUser[] users = ApplicationUserGenerator.InitializeDataForApplicationUsers();
        // City[] cities = CityGenerator.InitializeDataForCities();
        // District[] districts = DistrictGenerator.InitializeDataForDistricts(cities);
        // Wallet[] wallets = WalletGenerator.InitializeDataForWallets(users);
        // Deposit[] deposits = DepositGenerator.InitializeDataForDeposits(users, wallets);
        // Transaction[] transactions = TransactionGenerator.InitializeDataForTransactions(
        //     users,
        //     wallets,
        //     deposits
        // );
        // Ward[] wards = WardGenerator.InitializeDataForWards(districts);
        // CourtGroup[] courtGroups = CourtGroupGenerator.InitializeDataForCourtGroups(
        //     users,
        //     wards,
        //     wallets
        // );
        // Media[] media = MediaGenerator.InitializeDataForMedia(users, courtGroups);
        // CourtYard[] courtYards = CourtYardGenerator.InitializeDataForCourtYards(courtGroups);
        // Cost[] costs = CostGenerator.InitializeDataForCosts(courtYards);
        // Slot[] slots = SlotGenerator.InitializeDataForSlots(courtYards);
        // Date[] dates = DateGenerator.InitializeDataForDates();
        // DateCourtGroup[] dateCourtGroups = DateCourtGroupGenerator.InitializeDataForDateCourtGroup(
        //     courtGroups,
        //     dates
        // );
        // Booking[] bookings = BookingGenerator.InitializeDataForBookings(
        //     users,
        //     courtYards,
        //     courtGroups,
        //     dates
        // );
        // BookMark[] bookMarks = BookmarkGenerator.InitializeDataForBookMarks(users, courtGroups);
        // SlotBooking[] slotBookings = SlotBookingGenerator.InitializeDataForSlotBookings(
        //     slots,
        //     bookings
        // );

        // builder.Entity<ApplicationUser>().HasData(users);
        // builder.Entity<Booking>().HasData(bookings);
        // builder.Entity<BookMark>().HasData(bookMarks);
        // builder.Entity<City>().HasData(cities);
        // builder.Entity<Cost>().HasData(costs);
        // builder.Entity<CourtGroup>().HasData(courtGroups);
        // builder.Entity<CourtYard>().HasData(courtYards);
        // builder.Entity<Date>().HasData(dates);
        // builder.Entity<DateCourtGroup>().HasData(dateCourtGroups);
        // builder.Entity<Deposit>().HasData(deposits);
        // builder.Entity<District>().HasData(districts);
        // builder.Entity<Media>().HasData(media);
        // builder.Entity<Slot>().HasData(slots);
        // builder.Entity<SlotBooking>().HasData(slotBookings);
        // builder.Entity<Transaction>().HasData(transactions);
        // builder.Entity<Wallet>().HasData(wallets);
        // builder.Entity<Ward>().HasData(wards);
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

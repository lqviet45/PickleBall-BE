using Bogus;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.FakeDataGenerator;

public static class SlotBookingGenerator
{
    public static SlotBooking[] InitializeDataForSlotBookings(Slot[] slots, Booking[] bookings)
    {
        return new Faker<SlotBooking>()
            .UseSeed(2)
            .RuleFor(slotBooking => slotBooking.Id, f => f.Random.Guid())
            .RuleFor(slotBooking => slotBooking.SlotId, f => f.PickRandom(slots).Id)
            .RuleFor(slotBooking => slotBooking.BookingId, f => f.PickRandom(bookings).Id)
            .RuleFor(slotBooking => slotBooking.CreatedOnUtc, f => f.Date.Past())
            .RuleFor(slotBooking => slotBooking.ModifiedOnUtc, f => f.Date.Past())
            .RuleFor(slotBooking => slotBooking.IsDeleted, f => f.Random.Bool())
            .Generate(50)
            .ToArray();
    }
}

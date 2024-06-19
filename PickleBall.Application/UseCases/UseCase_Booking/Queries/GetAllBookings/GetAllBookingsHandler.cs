using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Booking.Queries.GetAllBookings;

internal sealed class GetAllBookingsHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<GetAllBookingsQuery, Result<IEnumerable<BookingDto>>>
{
    public async Task<Result<IEnumerable<BookingDto>>> Handle(
        GetAllBookingsQuery request,
        CancellationToken cancellationToken
    )
    {
        var bookings = await unitOfWork.RepositoryBooking.GetAllBookingsAsync(
            trackChanges: false,
            cancellationToken
        );

        var bookingDtos = mapper.Map<IEnumerable<BookingDto>>(bookings);

        return Result<IEnumerable<BookingDto>>.Success(bookingDtos);
    }
}

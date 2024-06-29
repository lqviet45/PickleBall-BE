using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.DTOs.ApplicationUserDtos;
using PickleBall.Domain.DTOs.BookingDtos;

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
            request.BookingParameters,
            cancellationToken
        );
        var bookingDtos = mapper.Map<IEnumerable<BookingDto>>(bookings);

        foreach (var booking in bookings)
        {
            var user = await unitOfWork.RepositoryApplicationUser.GetUserByConditionAsync(
                u => u.Id == booking.UserId,
                trackChanges: false,
                cancellationToken
            );

            bookingDtos.First(b => b.Id == booking.Id).User = mapper.Map<ApplicationUserDto>(user);
        }

        return Result<IEnumerable<BookingDto>>.Success(bookingDtos);
    }
}

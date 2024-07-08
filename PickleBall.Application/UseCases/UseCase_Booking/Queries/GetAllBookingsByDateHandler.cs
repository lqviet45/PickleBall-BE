using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.DTOs.ApplicationUserDtos;
using PickleBall.Domain.DTOs.BookingDtos;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_Booking.Queries;

internal sealed class GetAllBookingsByDateHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<GetAllBookingsByDateQuery, Result<PagedList<BookingDto>>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task<Result<PagedList<BookingDto>>> Handle(
        GetAllBookingsByDateQuery request,
        CancellationToken cancellationToken
    )
    {
        var date = await _unitOfWork.RepositoryDate.GetEntityByConditionAsync(
            d => d.DateWorking.Date == request.Date.Date,
            request.TrackChanges,
            cancellationToken
        );
        if (date == null)
            return Result.NotFound("Date is not found");

        IEnumerable<Booking> bookings =
            await _unitOfWork.RepositoryBooking.GetAllBookingsByConditionAsync(
                b => (b.DateId == date.Id) && (b.CourtGroupId == request.CourtGroupId),
                request.TrackChanges,
                request.BookingParameters,
                cancellationToken
            );

        if (!bookings.Any())
            return Result.NotFound("Booking is not found");

        var bookingDtos = _mapper.Map<IEnumerable<BookingDto>>(bookings);

        foreach (var booking in bookings)
        {
            var user = await unitOfWork.RepositoryApplicationUser.GetUserByConditionAsync(
                u => u.Id == booking.UserId,
                trackChanges: false,
                cancellationToken
            );

            bookingDtos.First(b => b.Id == booking.Id).User = mapper.Map<ApplicationUserDto>(user);
        }

        var pagedList = PagedList<BookingDto>.ToPagedList(
            bookingDtos,
            request.BookingParameters.PageNumber,
            request.BookingParameters.PageSize
        );

        return Result<PagedList<BookingDto>>.Success(pagedList, "Booking is found successfully");
    }
}

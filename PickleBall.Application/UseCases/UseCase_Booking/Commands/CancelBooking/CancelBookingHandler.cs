using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Application.UseCases.UseCase_Booking.Commands.CancelBooking;

public class CancelBookingHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<CancelBookingCommand, Result<BookingDto>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task<Result<BookingDto>> Handle(
        CancelBookingCommand request,
        CancellationToken cancellationToken
    )
    {
        var booking = await _unitOfWork.RepositoryBooking.GetBookingByIdAsync(
            request.Id,
            false,
            cancellationToken
        );
        if (booking is null)
            return Result.NotFound("Booking not found");

        if (booking.BookingStatus is BookingStatus.Pending or BookingStatus.Confirmed)
            booking.BookingStatus = BookingStatus.Cancelled;

        _unitOfWork.RepositoryBooking.UpdateAsync(booking);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var bookingDto = _mapper.Map<BookingDto>(booking);

        return Result<BookingDto>.Success(bookingDto);
    }
}

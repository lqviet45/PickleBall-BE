using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs.BookingDtos;

namespace PickleBall.Application.UseCases.UseCase_Booking.Queries.GetBookingById
{
    internal sealed class GetBookingByIdHandler
        : IRequestHandler<GetBookingByIdQuery, Result<BookingDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetBookingByIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<BookingDto>> Handle(
            GetBookingByIdQuery request,
            CancellationToken cancellationToken
        )
        {
            var booking = await _unitOfWork.RepositoryBooking.GetBookingByIdAsync(
                request.BookingId,
                request.TrackChanges,
                cancellationToken
            );

            if (booking is null)
                return Result.NotFound("Booking is not found");

            var transaction = await _unitOfWork.RepositoryTransaction.GetEntityByConditionAsync(
                t => t.BookingId == request.BookingId,
                request.TrackChanges,
                cancellationToken
            );

            var bookingDto = _mapper.Map<BookingDto>(booking);

            if (transaction != null)
                bookingDto.Amount = transaction.Amount;

            if (booking.SlotBookings != null)
                bookingDto.Amount = booking.SlotBookings.Count * booking.CourtGroup.Price;

            return Result.Success(bookingDto, "Booking is found successfully");
        }
    }
}

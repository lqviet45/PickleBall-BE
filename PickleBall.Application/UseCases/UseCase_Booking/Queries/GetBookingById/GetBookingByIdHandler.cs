using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Booking.Queries.GetBookingById
{
    internal sealed class GetBookingByIdHandler : IRequestHandler<GetBookingByIdQuery, Result<BookingDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetBookingByIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Result<BookingDto>> Handle(GetBookingByIdQuery request, CancellationToken cancellationToken)
        {
            var booking = await _unitOfWork.RepositoryBooking.GetEntityByConditionAsync(
                               b => b.Id == request.BookingId,
                               request.TrackChanges,
                               cancellationToken);

            if (booking is null)
                return Result.NotFound("Booking is not found");

            var bookingDto = _mapper.Map<BookingDto>(booking);

            return Result.Success(bookingDto, "Booking is found successfully");
        }
    }
}

using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Booking.Queries.GetBookingByUserId
{
    internal sealed class GetBookingByUserIdHandler : IRequestHandler<GetBookingByUserIdQuery, Result<IEnumerable<BookingDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetBookingByUserIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<IEnumerable<BookingDto>>> Handle(GetBookingByUserIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.RepositoryApplicationUser.GetUserByIdAsync(request.UserId, request.TrackChanges, cancellationToken);
            if (user == null)
            {
                return Result.NotFound("User is not found");
            }

            var bookings = await _unitOfWork.RepositoryBooking.GetBookingsByUserIdAsync(
                               request.UserId,
                               request.TrackChanges,
                               cancellationToken);

            if (!bookings.Any())
            {
                return Result.NotFound("Bookings are not found");
            }

            var bookingsDto = _mapper.Map<IEnumerable<BookingDto>>(bookings);
            return Result.Success(bookingsDto);
        }
    }
}

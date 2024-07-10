using Ardalis.Result;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs.BookingDtos;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_Booking.Queries.GetBookingsByCourtGroupId
{
    internal sealed class GetBookingsByCourtGroupIdHandler : IRequestHandler<GetBookingsByCourtGroupIdQuery, Result<PagedList<BookingDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetBookingsByCourtGroupIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<PagedList<BookingDto>>> Handle(GetBookingsByCourtGroupIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.RepositoryBooking.GetEntitiesByConditionAsync(
                b => b.CourtGroupId == request.CourtGroupId,
                request.TrackChanges,
                cancellationToken,
                b => b.Include(b => b.CourtGroup)
                .ThenInclude(b => b.User)
                .Include(b => b.CourtYard)
                .Include(booking => booking.Date)
                .OrderByDescending(booking => booking.CreatedOnUtc));

            if (!result.Any())
                return Result.NotFound("Bookings are not found");

            var bookingsDto = _mapper.Map<IEnumerable<BookingDto>>(result);

            var pagedList = PagedList<BookingDto>.ToPagedList(
                               bookingsDto,
                               request.BookingParameters.PageNumber,
                               request.BookingParameters.PageSize);

            return Result.Success(pagedList, "Bookings are found successfully");
        }
    }
}

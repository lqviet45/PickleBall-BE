﻿using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs.BookingDtos;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_Booking.Queries.GetBookingByUserId
{
    internal sealed class GetBookingByUserIdHandler
        : IRequestHandler<GetBookingByUserIdQuery, Result<PagedList<BookingDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetBookingByUserIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<PagedList<BookingDto>>> Handle(
            GetBookingByUserIdQuery request,
            CancellationToken cancellationToken
        )
        {
            var user = await _unitOfWork.RepositoryApplicationUser.GetUserByConditionAsync(
                u => u.Id == request.UserId,
                request.TrackChanges,
                cancellationToken
            );
            if (user == null)
            {
                return Result.NotFound("User is not found");
            }

            var bookings = await _unitOfWork.RepositoryBooking.GetAllBookingsByUserIdAsync(
                b => b.UserId == request.UserId
                && (request.BookingStatus != null ? b.BookingStatus == request.BookingStatus : true),
                request.TrackChanges,
                request.BookingParameters,
                cancellationToken
            );

            var bookingsDto = _mapper.Map<IEnumerable<BookingDto>>(bookings);

            var pagedList = PagedList<BookingDto>.ToPagedList(
                bookingsDto,
                request.BookingParameters.PageNumber,
                request.BookingParameters.PageSize
            );

            return Result.Success(pagedList);
        }
    }
}

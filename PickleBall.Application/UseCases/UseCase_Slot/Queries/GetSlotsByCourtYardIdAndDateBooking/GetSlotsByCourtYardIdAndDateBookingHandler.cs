using Ardalis.Result;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickleBall.Application.UseCases.UseCase_Slot.Queries.GetSlotsByCourtYardIdAndDateBooking
{
    internal sealed class GetSlotsByCourtYardIdAndDateBookingHandler : IRequestHandler<GetSlotsByCourtYardIdAndDateBookingQuery, Result<IEnumerable<SlotDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetSlotsByCourtYardIdAndDateBookingHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<IEnumerable<SlotDto>>> Handle(GetSlotsByCourtYardIdAndDateBookingQuery request, CancellationToken cancellationToken)
        {
            var courtYard = await _unitOfWork.RepositoryCourtYard.GetEntityByConditionAsync(
                               u => u.Id == request.CourtYardId,
                               request.TrackChanges,
                               cancellationToken);

            if (courtYard == null)
                return Result.NotFound("CourtYard is not found");

            var slots = await _unitOfWork.RepositorySlot.GetEntitiesByConditionAsync(
                s => s.CourtYardId == request.CourtYardId,
                request.TrackChanges,
                cancellationToken,
                s => s.Include(s => s.SlotBookings));

            if (!slots.Any())
                return Result.NotFound("Slots are not found");

            var slotDtos = _mapper.Map<IEnumerable<SlotDto>>(slots).
                Select(s => new SlotDto
                {
                    Id = s.Id,
                    CourtYardId = s.CourtYardId,
                    SlotName = s.SlotName,
                    Status = s.Status,
                    CreatedOnUtc = s.CreatedOnUtc,
                    ModifiedOnUtc = s.ModifiedOnUtc,
                    IsBooked = s.SlotBookings.Any(sb => sb.BookingDate.Date == request.DateBooking.Date)
                });

            return Result.Success(slotDtos);
        }
    }
}

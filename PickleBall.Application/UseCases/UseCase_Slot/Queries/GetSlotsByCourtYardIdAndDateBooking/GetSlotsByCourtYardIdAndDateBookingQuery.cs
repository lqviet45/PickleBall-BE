using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickleBall.Application.UseCases.UseCase_Slot.Queries.GetSlotsByCourtYardIdAndDateBooking
{
    public class GetSlotsByCourtYardIdAndDateBookingQuery : IRequest<Result<IEnumerable<SlotDto>>>
    {
        public Guid CourtYardId { get; set; }
        public DateTime DateBooking { get; set; }
        public bool TrackChanges { get; set; } = false;
    }
}

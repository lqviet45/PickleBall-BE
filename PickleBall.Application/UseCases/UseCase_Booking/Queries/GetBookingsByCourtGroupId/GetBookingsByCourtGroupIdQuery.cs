using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.BookingDtos;
using PickleBall.Domain.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickleBall.Application.UseCases.UseCase_Booking.Queries.GetBookingsByCourtGroupId
{
    public class GetBookingsByCourtGroupIdQuery : IRequest<Result<PagedList<BookingDto>>>
    {
        public Guid CourtGroupId { get; set; }
        public bool TrackChanges { get; set; } = false;
        public BookingParameters BookingParameters { get; set; } = new BookingParameters();
    }
}

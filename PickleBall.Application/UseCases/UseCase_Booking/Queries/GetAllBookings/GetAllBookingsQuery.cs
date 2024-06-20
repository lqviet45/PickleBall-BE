using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Booking.Queries.GetAllBookings;

public class GetAllBookingsQuery : IRequest<Result<IEnumerable<BookingDto>>> { }

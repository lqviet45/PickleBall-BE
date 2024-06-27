using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;

namespace PickleBall.Application.UseCases.UseCase_CourtYard.Commands.DeleteCourtYard;

internal sealed class DeleteCourtYardHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<DeleteCourtYardCommand, Result>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<Result> Handle(
        DeleteCourtYardCommand request,
        CancellationToken cancellationToken
    )
    {
        // Check if the court yard exists
        var courtYard = await _unitOfWork.RepositoryCourtYard.GetEntityByConditionAsync(
            x => x.Id == request.Id,
            false,
            cancellationToken
        );
        if (courtYard == null)
            return Result.NotFound();

        // Delete all bookings, costs, and slots associated with the court yard
        var bookings = await _unitOfWork.RepositoryBooking.GetEntitiesByConditionAsync(
            x => x.CourtYardId == request.Id,
            false,
            cancellationToken
        );
        foreach (var booking in bookings)
            _unitOfWork.RepositoryBooking.DeleteAsync(booking);

        var costs = await _unitOfWork.RepositoryCost.GetEntitiesByConditionAsync(
            x => x.CourtYardId == request.Id,
            false,
            cancellationToken
        );
        foreach (var cost in costs)
            _unitOfWork.RepositoryCost.DeleteAsync(cost);

        var slots = await _unitOfWork.RepositorySlot.GetEntitiesByConditionAsync(
            x => x.CourtYardId == request.Id,
            false,
            cancellationToken
        );
        foreach (var slot in slots)
        {
            _unitOfWork.RepositorySlot.DeleteAsync(slot);

            var slotBookings = await _unitOfWork.RepositorySlotBooking.GetEntitiesByConditionAsync(
                x => x.SlotId == slot.Id,
                false,
                cancellationToken
            );
            foreach (var slotBooking in slotBookings)
                _unitOfWork.RepositorySlotBooking.DeleteAsync(slotBooking);
        }

        _unitOfWork.RepositoryCourtYard.DeleteAsync(courtYard);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.SuccessWithMessage("CourtYard deleted successfully.");
    }
}

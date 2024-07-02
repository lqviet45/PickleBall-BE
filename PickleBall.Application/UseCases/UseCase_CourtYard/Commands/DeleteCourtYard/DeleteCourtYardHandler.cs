using Ardalis.Result;
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
            return Result.NotFound("CourtYard not found.");

        await DeleteAssociatedEntitiesAsync(request.Id, cancellationToken);

        _unitOfWork.RepositoryCourtYard.DeleteAsync(courtYard);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.SuccessWithMessage("CourtYard deleted successfully.");
    }

    private async Task DeleteAssociatedEntitiesAsync(
        Guid courtYardId,
        CancellationToken cancellationToken
    )
    {
        // Delete bookings
        var bookings = await _unitOfWork.RepositoryBooking.GetEntitiesByConditionAsync(
            x => x.CourtYardId == courtYardId,
            false,
            cancellationToken
        );
        await _unitOfWork.RepositoryBooking.DeleteRange(bookings);

        // Delete costs
        var costs = await _unitOfWork.RepositoryCost.GetEntitiesByConditionAsync(
            x => x.CourtYardId == courtYardId,
            false,
            cancellationToken
        );
        await _unitOfWork.RepositoryCost.DeleteRange(costs);

        // Delete slots and associated slot bookings
        var slots = await _unitOfWork.RepositorySlot.GetEntitiesByConditionAsync(
            x => x.CourtYardId == courtYardId,
            false,
            cancellationToken
        );

        var slotIds = slots.Select(slot => slot.Id).ToList();
        var slotBookings = await _unitOfWork.RepositorySlotBooking.GetEntitiesByConditionAsync(
            x => slotIds.Contains(x.SlotId),
            false,
            cancellationToken
        );
        await _unitOfWork.RepositorySlotBooking.DeleteRange(slotBookings);
        await _unitOfWork.RepositorySlot.DeleteRange(slots);
    }
}

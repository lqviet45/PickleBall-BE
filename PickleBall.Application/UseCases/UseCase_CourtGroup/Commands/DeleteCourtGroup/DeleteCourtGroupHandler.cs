using Ardalis.Result;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Commands.DeleteCourtGroup
{
    internal class DeleteCourtGroupHandler : IRequestHandler<DeleteCourtGroupCommand, Result>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCourtGroupHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result> Handle(
            DeleteCourtGroupCommand request,
            CancellationToken cancellationToken
        )
        {
            var courtGroup = await _unitOfWork.RepositoryCourtGroup.GetEntityByConditionAsync(
                c => c.Id == request.Id,
                false,
                cancellationToken
            );

            if (courtGroup == null)
                return Result.NotFound("Court group is not found");

            await DeleteAssociatedEntitiesAsync(request.Id, cancellationToken);

            _unitOfWork.RepositoryCourtGroup.DeleteAsync(courtGroup);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Result.SuccessWithMessage("CourtGroup deleted successfully");
        }

        private async Task DeleteAssociatedEntitiesAsync(
            Guid courtGroupId,
            CancellationToken cancellationToken
        )
        {
            var bookings = await _unitOfWork.RepositoryBooking.GetEntitiesByConditionAsync(
                x => x.CourtGroupId == courtGroupId,
                false,
                cancellationToken
            );
            await _unitOfWork.RepositoryBooking.DeleteRange(bookings);

            var courtYards = await _unitOfWork.RepositoryCourtYard.GetEntitiesByConditionAsync(
                x => x.CourtGroupId == courtGroupId,
                false,
                cancellationToken
            );
            await _unitOfWork.RepositoryCourtYard.DeleteRange(courtYards);

            var courtYardIds = courtYards.Select(courtYard => courtYard.Id).ToList();

            var costs = await _unitOfWork.RepositoryCost.GetEntitiesByConditionAsync(
                x => courtYardIds.Contains(x.CourtYardId),
                false,
                cancellationToken
            );
            await _unitOfWork.RepositoryCost.DeleteRange(costs);

            var slots = await _unitOfWork.RepositorySlot.GetEntitiesByConditionAsync(
                x => courtYardIds.Contains(x.CourtYardId),
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
}

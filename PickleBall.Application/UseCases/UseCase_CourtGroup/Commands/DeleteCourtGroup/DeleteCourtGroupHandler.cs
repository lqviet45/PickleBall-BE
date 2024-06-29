using Ardalis.Result;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Commands.DeleteCourtGroup
{
    internal class DeleteCourtGroupHandler : IRequestHandler<DeleteCourtGroupCommand, Result>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteCourtGroupHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result> Handle(DeleteCourtGroupCommand request, CancellationToken cancellationToken)
        {
            var courtGroup = await _unitOfWork.RepositoryCourtGroup.GetEntityByConditionAsync(
                c => c.Id == request.Id, false, cancellationToken, c => c.Include(c => c.CourtYards));

            if (courtGroup == null)
                return Result.NotFound("coutgroup is not found");


            foreach (var courtYard in courtGroup.CourtYards)
            {
                var bookings = await _unitOfWork.RepositoryBooking.GetEntitiesByConditionAsync(
                    x => x.CourtYardId == courtYard.Id,
                    false,
                    cancellationToken
                );
                foreach (var booking in bookings)
                    _unitOfWork.RepositoryBooking.DeleteAsync(booking);

                var costs = await _unitOfWork.RepositoryCost.GetEntitiesByConditionAsync(
                    x => x.CourtYardId == courtYard.Id,
                    false,
                    cancellationToken
                );
                foreach (var cost in costs)
                    _unitOfWork.RepositoryCost.DeleteAsync(cost);

                var slots = await _unitOfWork.RepositorySlot.GetEntitiesByConditionAsync(
                    x => x.CourtYardId == courtYard.Id,
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
            }

            _unitOfWork.RepositoryCourtGroup.DeleteAsync(courtGroup);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Result.SuccessWithMessage("CourtGroup deleted successfully");
        }
    }
}

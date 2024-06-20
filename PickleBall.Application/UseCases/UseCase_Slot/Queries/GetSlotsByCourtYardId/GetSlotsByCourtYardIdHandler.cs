using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Slot.Queries.GetSlotsByCourtYardId
{
    internal sealed class GetSlotsByCourtYardIdHandler : IRequestHandler<GetSlotsByCourtYardIdQuery, Result<IEnumerable<SlotDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetSlotsByCourtYardIdHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<IEnumerable<SlotDto>>> Handle(GetSlotsByCourtYardIdQuery request, CancellationToken cancellationToken)
        {
            var slots = await _unitOfWork.RepositorySlot.GetSlotsByCourtYardIdAsync(
                               request.CourtYardId,
                               request.TrackChanges,
                               cancellationToken
            );

            if (!slots.Any())
                return Result.NotFound("This court yard does not have any slots");

            var slotDtos = _mapper.Map<IEnumerable<SlotDto>>(slots);

            return Result.Success(slotDtos, "Slot is founded successfully");
        }
    }
}

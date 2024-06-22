using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Slot.Queries.GetSlotsByName
{
    internal sealed class GetSlotsByNameHandler : IRequestHandler<GetSlotsByNameQuery, Result<IEnumerable<SlotDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetSlotsByNameHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<IEnumerable<SlotDto>>> Handle(GetSlotsByNameQuery request, CancellationToken cancellationToken)
        {
            var slots = await _unitOfWork.RepositorySlot.GetEntitiesByConditionAsync(
                slot => slot.SlotName != null && slot.SlotName.Contains(request.Name),
                request.TrackChanges,
                cancellationToken);

            if (!slots.Any())
                return Result.NotFound("slots are not found");

            var slotDtos = _mapper.Map<IEnumerable<SlotDto>>(slots);

            return Result.Success(slotDtos, "slots are found successfully!");
        }
    }
}

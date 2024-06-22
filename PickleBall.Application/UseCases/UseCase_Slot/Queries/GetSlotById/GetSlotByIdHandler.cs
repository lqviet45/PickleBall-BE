using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Slot.Queries.GetSlotById
{
    internal sealed class GetSlotByIdHandler : IRequestHandler<GetSlotByIdQuery, Result<SlotDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetSlotByIdHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<SlotDto>> Handle(GetSlotByIdQuery request, CancellationToken cancellationToken)
        {
            var slot = await _unitOfWork.RepositorySlot.GetEntityByConditionAsync(
                               s => s.Id == request.Id,
                               request.TrackChanges,
                               cancellationToken);

            if (slot is null)
                return Result.NotFound("Slot is not found");

            var slotDto = _mapper.Map<SlotDto>(slot);

            return Result.Success(slotDto, "Slot is founded successfully");
        }
    }
}

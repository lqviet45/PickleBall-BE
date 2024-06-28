using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Application.UseCases.UseCase_CourtYard.Commands.CreateCourtYardByCourtGroupId;

public class CreateCourtYardHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<CreateCourtYardCommand, Result<CourtYardDto>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task<Result<CourtYardDto>> Handle(
        CreateCourtYardCommand request,
        CancellationToken cancellationToken
    )
    {
        var courtGroup = await _unitOfWork.RepositoryCourtGroup.GetCourtGroupByConditionAsync(
            c => c.Id == request.CourtGroupId,
            false,
            cancellationToken
        );
        if (courtGroup is null)
            return Result.NotFound("CourtGroup is not found");

        var courtYard = new CourtYard()
        {
            CourtGroupId = request.CourtGroupId,
            Name = request.Name,
            CourtYardStatus = CourtYardStatus.Available,
            Type = "Outdoor",
            CreatedOnUtc = DateTimeOffset.UtcNow
        };

        _unitOfWork.RepositoryCourtYard.AddAsync(courtYard);

        CreateSlot(courtYard);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var courtYardDto = _mapper.Map<CourtYardDto>(courtYard);

        return Result<CourtYardDto>.Success(courtYardDto);
    }

    private void CreateSlot(CourtYard courtYard)
    {
        string[] slots =
        [
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00"
        ];

        foreach (var slot in slots)
        {
            var slotEntity = new Slot()
            {
                CourtYardId = courtYard.Id,
                SlotName = slot,
                Status = "Available",
                CreatedOnUtc = DateTimeOffset.UtcNow
            };

            _unitOfWork.RepositorySlot.AddAsync(slotEntity);
        }
    }
}

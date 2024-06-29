using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs.CourtGroupsDtos;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Commands.UpdateCourtGroup;

public class UpdateCourtGroupPriceHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<UpdateCourtGroupCommand, Result<CourtGroupDto>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task<Result<CourtGroupDto>> Handle(
        UpdateCourtGroupCommand request,
        CancellationToken cancellationToken
    )
    {
        var courtGroup = await _unitOfWork.RepositoryCourtGroup.GetCourtGroupByConditionAsync(
            c => c.Id == request.Id,
            true,
            cancellationToken
        );

        if (courtGroup is null)
            return Result.NotFound("Court Group not found");

        if (request.MinSlots > request.MaxSlots)
            return Result.Error("MinSlots cannot be greater than MaxSlots");

        if (request.MinSlots < 0 || request.MaxSlots < 0)
            return Result.Error("MinSlots and MaxSlots cannot be less than 0");

        if (request.Price < 0)
            return Result.Error("Price cannot be less than 0");

        if (request.MinSlots == 0 || request.MaxSlots == 0)
            return Result.Error("MinSlots and MaxSlots cannot be 0");

        courtGroup.Name = request.Name ?? courtGroup.Name;
        courtGroup.Price = request.Price;
        courtGroup.MinSlots = request.MinSlots;
        courtGroup.MaxSlots = request.MaxSlots;
        courtGroup.ModifiedOnUtc = DateTime.UtcNow;

        _unitOfWork.RepositoryCourtGroup.UpdateAsync(courtGroup);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var courtGroupDto = _mapper.Map<CourtGroupDto>(courtGroup);

        return Result.Success(courtGroupDto);
    }
}

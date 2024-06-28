using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Commands.UpdateCourtGroupPrice;

public class UpdateCourtGroupPriceHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<UpdateCourtGroupPriceCommand, Result<CourtGroupDto>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task<Result<CourtGroupDto>> Handle(
        UpdateCourtGroupPriceCommand request,
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

        courtGroup.Price = request.Price;

        _unitOfWork.RepositoryCourtGroup.UpdateAsync(courtGroup);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var courtGroupDto = _mapper.Map<CourtGroupDto>(courtGroup);

        return Result.Success(courtGroupDto);
    }
}

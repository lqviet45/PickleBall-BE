using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_CourtYard.Commands.UpdateCourtYard;

public class UpdateCourtYardHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<UpdateCourtYardCommand, Result<CourtYardDto>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task<Result<CourtYardDto>> Handle(
        UpdateCourtYardCommand request,
        CancellationToken cancellationToken
    )
    {
        var courtyard = await _unitOfWork.RepositoryCourtYard.GetCourtYardByIdAsync(
            request.CourtYardId,
            false,
            cancellationToken
        );
        if (courtyard is null)
            return Result.NotFound("Court yard not found");

        courtyard.Name = request.Name ?? courtyard.Name;
        courtyard.CourtYardStatus = request.CourtYardStatus;

        _unitOfWork.RepositoryCourtYard.UpdateAsync(courtyard);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result<CourtYardDto>.Success(_mapper.Map<CourtYardDto>(courtyard));
    }
}

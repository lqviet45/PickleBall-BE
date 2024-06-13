using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_District.Queries.GetDistrictById;

internal sealed class GetDistrictByIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<GetDistrictByIdQuery, Result<DistrictDto>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task<Result<DistrictDto>> Handle(
        GetDistrictByIdQuery request,
        CancellationToken cancellationToken
    )
    {
        District? district = await _unitOfWork.RepositoryDistrict.GetDistrictByIdAsync(
            request.Id,
            request.TrackChanges,
            cancellationToken
        );

        if (district is null)
            return Result.NotFound("District is not found");

        DistrictDto districtDto = _mapper.Map<DistrictDto>(district);

        return Result.Success(districtDto, "District is found successfully");
    }
}

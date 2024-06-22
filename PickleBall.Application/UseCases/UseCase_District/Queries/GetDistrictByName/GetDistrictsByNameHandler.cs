using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_District.Queries.GetDistrictByName
{
    internal sealed class GetDistrictsByNameHandler : IRequestHandler<GetDistrictsByNameQuery, Result<IEnumerable<DistrictDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetDistrictsByNameHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<IEnumerable<DistrictDto>>> Handle(GetDistrictsByNameQuery request, CancellationToken cancellationToken)
        {
            var districts = await _unitOfWork.RepositoryDistrict.GetEntitiesByConditionAsync(
                               district => district.Name != null && district.Name.Contains(request.Name),
                               request.TrackChanges,
                               cancellationToken);

            if (!districts.Any())
                return Result.NotFound("Districts are not found");

            var districtDtos = _mapper.Map<IEnumerable<DistrictDto>>(districts);

            return Result.Success(districtDtos, "Districts are found successfully!");
        }
    }
}

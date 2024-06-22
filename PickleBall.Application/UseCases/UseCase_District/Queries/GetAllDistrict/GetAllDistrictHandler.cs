using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_District.Queries.GetAllDistrict
{
    internal sealed class GetAllDistrictHandler : IRequestHandler<GetAllDistrictQuery, Result<IEnumerable<DistrictDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllDistrictHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<IEnumerable<DistrictDto>>> Handle(GetAllDistrictQuery request, CancellationToken cancellationToken)
        {
            var districts = await _unitOfWork.RepositoryDistrict.GetAllAsync(request.TrackChanges, cancellationToken);

            if (!districts.Any())
                return Result.NotFound("Districts are not found");

            var districtDtos = _mapper.Map<IEnumerable<DistrictDto>>(districts);
            return Result.Success(districtDtos, "Districts are found successfully!");
        }
    }
}

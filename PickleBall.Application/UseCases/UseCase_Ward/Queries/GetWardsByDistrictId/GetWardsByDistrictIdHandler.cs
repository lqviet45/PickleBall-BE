using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_Ward.Queries.GetWardsByDistrictId
{
    internal sealed class GetWardsByDistrictIdHandler : IRequestHandler<GetWardsByDistrictIdQuery, Result<IEnumerable<WardDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetWardsByDistrictIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<IEnumerable<WardDto>>> Handle(GetWardsByDistrictIdQuery request, CancellationToken cancellationToken)
        {
            var wards = await _unitOfWork.RepositoryWard.GetEntitiesByConditionAsync(
                               w => w.DistrictId == request.DistrictId,
                               request.TrackChanges,
                               cancellationToken);

            var wardsDto = _mapper.Map<IEnumerable<WardDto>>(wards.OrderBy(w => w.Name));

            return Result.Success(wardsDto, "Wards are found successfully");
        }
    }
}

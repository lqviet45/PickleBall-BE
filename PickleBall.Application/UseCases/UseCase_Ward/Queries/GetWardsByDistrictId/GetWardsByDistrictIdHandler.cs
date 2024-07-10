using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_Ward.Queries.GetWardsByDistrictId
{
    internal sealed class GetWardsByDistrictIdHandler : IRequestHandler<GetWardsByDistrictIdQuery, Result<PagedList<WardDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetWardsByDistrictIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<PagedList<WardDto>>> Handle(GetWardsByDistrictIdQuery request, CancellationToken cancellationToken)
        {
            var wards = await _unitOfWork.RepositoryWard.GetEntitiesByConditionAsync(
                               w => w.DistrictId == request.DistrictId,
                               request.TrackChanges,
                               cancellationToken);

            if (!wards.Any())
                return Result.NotFound("Wards are not found");

            var wardsDto = _mapper.Map<IEnumerable<WardDto>>(wards);

            var pagedList = PagedList<WardDto>.ToPagedList(
                               wardsDto,
                               request.WardParameters.PageNumber,
                               request.WardParameters.PageSize);

            return Result.Success(pagedList, "Wards are found successfully");
        }
    }
}

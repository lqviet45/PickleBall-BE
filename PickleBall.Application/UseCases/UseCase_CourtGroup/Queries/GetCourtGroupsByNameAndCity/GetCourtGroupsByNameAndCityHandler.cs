using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetCourtGroupsByNameAndCity
{
    internal sealed class GetCourtGroupsByNameAndCityHandler : IRequestHandler<GetCourtGroupsByNameAndCityQuery, Result<IEnumerable<CourtGroupDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetCourtGroupsByNameAndCityHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<IEnumerable<CourtGroupDto>>> Handle(GetCourtGroupsByNameAndCityQuery request, CancellationToken cancellationToken)
        {
            var city = await _unitOfWork.RepositoryCity.GetEntityByConditionAsync(
                c => c.Name == request.CityName,
                request.TrackChanges,
                cancellationToken);

            if (city is null)
            {
                return Result.NotFound("City is not found");
            }

            var courtGroups = await _unitOfWork.RepositoryCourtGroup.GetCourtGroupsByConditionsAsync(
            c => c.Name != null && c.Name.Contains(request.Name) && !c.IsDeleted && c.Ward.District.City.Id == city.Id,
            request.TrackChanges,
            cancellationToken);

            if (!courtGroups.Any())
            {
                return Result.NotFound("Court groups not found in this city");
            }

            var courtGroupsDto = _mapper.Map<IEnumerable<CourtGroupDto>>(courtGroups);

            return Result.Success(courtGroupsDto, "Court groups found");
        }
    }
}

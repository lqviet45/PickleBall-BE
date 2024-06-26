using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetCourtGroupsByNameOrCity
{
    internal sealed class GetCourtGroupsByNameOrCityHandler : IRequestHandler<GetCourtGroupsByNameOrCityQuery, Result<IEnumerable<CourtGroupDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetCourtGroupsByNameOrCityHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<IEnumerable<CourtGroupDto>>> Handle(GetCourtGroupsByNameOrCityQuery request, CancellationToken cancellationToken)
        {
            var courtGroups = await _unitOfWork.RepositoryCourtGroup.GetCourtGroupsByConditionsAsync(
            c => (c.Name != null && c.Name.Contains(request.Name) && !string.IsNullOrWhiteSpace(request.Name)) || 
                (c.Ward != null && c.Ward.District != null &&
                c.Ward.District.City != null && c.Ward.District.City.Name != null &&
                c.Ward.District.City.Name.Contains(request.CityName) && !string.IsNullOrWhiteSpace(request.CityName)),
            request.TrackChanges,
            cancellationToken);

            if (!courtGroups.Any())
            {
                return Result.NotFound("There are no courtgroups meet this condition");
            }

            var courtGroupsDto = _mapper.Map<IEnumerable<CourtGroupDto>>(courtGroups);

            return Result.Success(courtGroupsDto, "Court groups found");
        }
    }
}

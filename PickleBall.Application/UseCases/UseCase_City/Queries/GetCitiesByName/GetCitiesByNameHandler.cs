using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_City.Queries.GetCitiesByName
{
    internal sealed class GetCitiesByNameHandler : IRequestHandler<GetCitiesByNameQuery, Result<IEnumerable<CityDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetCitiesByNameHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<IEnumerable<CityDto>>> Handle(GetCitiesByNameQuery request, CancellationToken cancellationToken)
        {
            var cities = await _unitOfWork.RepositoryCity.GetCitiesByNameAsync(
                 request.Name,
                 request.TrackChanges,
                 cancellationToken);

            if (!cities.Any())
            {
                return Result.NotFound("Cities not found");
            }

            var citiesDto = _mapper.Map<IEnumerable<CityDto>>(cities);

            return Result.Success(citiesDto, "Cities found");
        }
    }
}

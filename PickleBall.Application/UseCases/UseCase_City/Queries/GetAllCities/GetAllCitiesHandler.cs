using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetAllCities;

internal sealed class GetAllCitiesHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<GetAllCitiesQuery, Result<IEnumerable<CityDto>>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task<Result<IEnumerable<CityDto>>> Handle(
        GetAllCitiesQuery request,
        CancellationToken cancellationToken
    )
    {
        IEnumerable<City> cities = await _unitOfWork.RepositoryCity.GetAllCitiesAsync(
            request.TrackChanges,
            cancellationToken
        );

        if (cities is null)
            return Result.NotFound("City is not found");

        var citiesDto = _mapper.Map<IEnumerable<CityDto>>(cities);

        return Result.Success(citiesDto, "City is found successfully");
    }
}

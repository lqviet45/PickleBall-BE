using Ardalis.Result;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetAllCities;

internal sealed class GetAllCitiesHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<GetAllCitiesQuery, Result<IEnumerable<City>>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<Result<IEnumerable<City>>> Handle(
        GetAllCitiesQuery request,
        CancellationToken cancellationToken
    )
    {
        IEnumerable<City> cities = await _unitOfWork.RepositoryCity.GetAllCitiesAsync(
            cancellationToken
        );

        if (cities is null)
            return Result.NotFound("City is not found");

        return Result.Success(cities, "City is found successfully");
    }
}

using Ardalis.Result;
using MediatR;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetAllCities;

public class GetAllCitiesQuery : IRequest<Result<IEnumerable<City>>> { }

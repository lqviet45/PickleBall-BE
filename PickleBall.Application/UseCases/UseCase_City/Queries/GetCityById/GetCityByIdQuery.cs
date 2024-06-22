using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_City.Queries.GetCityById
{
    public class GetCityByIdQuery : IRequest<Result<CityDto>>
    {
        public int Id { get; set; }
        public bool trackChanges { get; set; }
    }
}

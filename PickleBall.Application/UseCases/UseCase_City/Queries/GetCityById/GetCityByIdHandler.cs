using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_City.Queries.GetCityById
{
    internal sealed class GetCityByIdHandler : IRequestHandler<GetCityByIdQuery, Result<CityDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetCityByIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<CityDto>> Handle(GetCityByIdQuery request, CancellationToken cancellationToken)
        {
            var city = await _unitOfWork.RepositoryCity.GetEntityByConditionAsync(
                               c => c.Id == request.Id,
                               request.trackChanges,
                               cancellationToken);
            if (city is null)
                return Result.NotFound("City is not found");

            var cityDto = _mapper.Map<CityDto>(city);

            return Result.Success(cityDto, "City is found successfully");
        }
    }
}

using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickleBall.Application.UseCases.UseCase_Ward.Queries.GetWardsByName
{
    internal sealed class GetWardsByNameHandler : IRequestHandler<GetWardsByNameQuery, Result<IEnumerable<WardDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetWardsByNameHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<IEnumerable<WardDto>>> Handle(GetWardsByNameQuery request, CancellationToken cancellationToken)
        {
            var wards = await _unitOfWork.RepositoryWard.GetEntitiesByConditionAsync(
                                           ward => ward.Name != null && ward.Name.Contains(request.Name),
                                           request.TrackChanges,
                                           cancellationToken);

            if (!wards.Any())
                return Result.NotFound("Wards are not found");

            var wardDtos = _mapper.Map<IEnumerable<WardDto>>(wards);
            return Result.Success(wardDtos, "Wards are found successfully!");
        }
    }
}

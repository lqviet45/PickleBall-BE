using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Ward.Queries
{
    internal sealed class GetAllWardHandler : IRequestHandler<GetAllWardQuery, Result<IEnumerable<WardDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllWardHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<IEnumerable<WardDto>>> Handle(GetAllWardQuery request, CancellationToken cancellationToken)
        {
            var wards = await _unitOfWork.RepositoryWard.GetAllAsync(request.TrackChanges, cancellationToken);

            if (!wards.Any())
                return Result.NotFound("Wards are not found");

            var wardDtos = _mapper.Map<IEnumerable<WardDto>>(wards);

            return Result.Success(wardDtos, "Wards are found successfully");
        }
    }
}

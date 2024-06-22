using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Ward.Queries.GetWardById
{
    internal sealed class GetWardByIdHandler : IRequestHandler<GetWardByIdQuery, Result<WardDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetWardByIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<WardDto>> Handle(GetWardByIdQuery request, CancellationToken cancellationToken)
        {
            var ward = await _unitOfWork.RepositoryWard.GetEntityByConditionAsync(
                               w => w.Id == request.Id,
                               request.TrackChanges,
                               cancellationToken);

            if (ward is null)
                return Result.NotFound("Ward is not found");

            var wardDto = _mapper.Map<WardDto>(ward);

            return Result.Success(wardDto, "Ward is found successfully");
        }
    }
}

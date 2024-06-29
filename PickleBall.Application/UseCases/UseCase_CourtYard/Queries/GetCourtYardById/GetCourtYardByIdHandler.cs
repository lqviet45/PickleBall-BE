using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs.CourtYardDtos;

namespace PickleBall.Application.UseCases.UseCase_CourtYard.Queries.GetCourtYardById
{
    internal sealed class GetCourtYardByIdHandler
        : IRequestHandler<GetCourtYardByIdQuery, Result<CourtYardDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetCourtYardByIdHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<CourtYardDto>> Handle(
            GetCourtYardByIdQuery request,
            CancellationToken cancellationToken
        )
        {
            var result = await _unitOfWork.RepositoryCourtYard.GetCourtYardByIdAsync(
                request.CourtYardId,
                request.TrackChanges,
                cancellationToken
            );

            if (result is null)
                return Result.NotFound("Court Yard is not found");

            var courtYardDto = _mapper.Map<CourtYardDto>(result);

            return Result.Success(courtYardDto, "Court Yard is found successfully");
        }
    }
}

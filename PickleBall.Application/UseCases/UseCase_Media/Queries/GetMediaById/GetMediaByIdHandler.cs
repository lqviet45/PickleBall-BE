using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Media.Queries.GetMediaById
{
    internal sealed class GetMediaByIdHandler : IRequestHandler<GetMediaByIdQuery, Result<MediaDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetMediaByIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<MediaDto>> Handle(GetMediaByIdQuery request, CancellationToken cancellationToken)
        {
            var media = await _unitOfWork.RepositoryMedia.GetEntityByConditionAsync(
                                              c => c.Id == request.Id,
                                              request.trackChanges,
                                              cancellationToken);
            if (media is null)
                return Result.NotFound("Media is not found");

            var mediaDto = _mapper.Map<MediaDto>(media);

            return Result.Success(mediaDto, "Media is found successfully");
        }
    }
}

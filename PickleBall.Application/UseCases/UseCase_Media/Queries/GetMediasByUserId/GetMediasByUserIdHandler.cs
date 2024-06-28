using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_Media.Queries.GetMediasByUserId
{
    internal sealed class GetMediasByUserIdHandler
        : IRequestHandler<GetMediasByUserIdQuery, Result<IEnumerable<MediaDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetMediasByUserIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<IEnumerable<MediaDto>>> Handle(
            GetMediasByUserIdQuery request,
            CancellationToken cancellationToken
        )
        {
            var user = await _unitOfWork.RepositoryApplicationUser.GetUserByConditionAsync(
                u => u.Id == request.UserId,
                request.TrackChanges,
                cancellationToken
            );

            if (user is null)
                return Result.NotFound("User is not found");

            var medias = await _unitOfWork.RepositoryMedia.GetMediasByUserId(
                request.UserId,
                request.TrackChanges
            );

            if (!medias.Any())
                return Result.NotFound("Medias are not found");

            var mediaDtos = _mapper.Map<IEnumerable<MediaDto>>(medias);

            return Result.Success(mediaDtos, "Medias are found successfully");
        }
    }
}

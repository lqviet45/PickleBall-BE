using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_BookMark.Queries.GetBookMarkByUserIdAndCourtGroupId
{
    internal sealed class GetBookMarkByUserIdAndCourtGroupIdHandler : IRequestHandler<GetBookMarkByUserIdAndCourtGroupIdQuery, Result<BookMarkDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetBookMarkByUserIdAndCourtGroupIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<BookMarkDto>> Handle(GetBookMarkByUserIdAndCourtGroupIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.RepositoryApplicationUser.GetEntityByConditionAsync(
                                              u => u.Id == request.UserId,
                                              false,
                                              cancellationToken);

            if (user is null)
                return Result.NotFound("User is not found");

            var courtGroup = await _unitOfWork.RepositoryCourtGroup.GetEntityByConditionAsync(
                                              c => c.Id == request.CourtGroupId,
                                              false,
                                              cancellationToken);

            if (courtGroup is null)
                return Result.NotFound("CourtGroup is not found");

            var bookMark = await _unitOfWork.RepositoryBookMark.GetBookMarkByConditionAsync(
                                              b => b.UserId == request.UserId && b.CourtGroupId == request.CourtGroupId,
                                              false,
                                              cancellationToken);

            if (bookMark is null || bookMark.IsDeleted)
                return Result.NotFound("BookMark is not found");

            var bookMarkDto = _mapper.Map<BookMarkDto>(bookMark);
            return Result.Success(bookMarkDto, "BookMark found successdully");
        }
    }
}

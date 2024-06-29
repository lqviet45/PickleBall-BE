using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_BookMark.Queries.GetAllBookMarkByUserId
{
    internal sealed class GetAllBookMarkByUserIdHandler : IRequestHandler<GetAllBookMarkByUserIdQuery, Result<IEnumerable<BookMarkDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllBookMarkByUserIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<IEnumerable<BookMarkDto>>> Handle(GetAllBookMarkByUserIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.RepositoryApplicationUser.GetEntityByConditionAsync(
                               u => u.Id == request.Id,
                               request.TrackChanges,
                               cancellationToken);

            if (user is null)
                return Result.NotFound("User is not found");

            var bookMarks = await _unitOfWork.RepositoryBookMark.GetAllBookMarksByConditionAsync(
                b => b.UserId == request.Id,
                request.TrackChanges,
                request.BookMarkParameters,
                cancellationToken);

            if (!bookMarks.Any())
                return Result.NotFound("There are no bookMarks");

            var bookMarksDto = _mapper.Map<IEnumerable<BookMarkDto>>(bookMarks);

            return Result.Success(bookMarksDto, "BookMarks found successfully");
        }
    }
}

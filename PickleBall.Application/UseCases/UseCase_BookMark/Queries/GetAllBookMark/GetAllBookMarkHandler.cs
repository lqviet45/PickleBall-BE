using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_BookMark.Queries.GetAllBookMark
{
    internal sealed class GetAllBookMarkHandler : IRequestHandler<GetAllBookMarkQuery, Result<IEnumerable<BookMarkDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllBookMarkHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<IEnumerable<BookMarkDto>>> Handle(GetAllBookMarkQuery request, CancellationToken cancellationToken)
        {
            var bookMarks = await _unitOfWork.RepositoryBookMark.GetAllBookMarksAsync(
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

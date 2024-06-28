using Ardalis.Result;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_BookMark.Queries.GetBookMarksByCourtGroupName
{
    internal sealed class GetBookMarksByCourtGroupNameHandler : IRequestHandler<GetBookMarksByCourtGroupNameQuery, Result<IEnumerable<BookMarkDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetBookMarksByCourtGroupNameHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<IEnumerable<BookMarkDto>>> Handle(
                       GetBookMarksByCourtGroupNameQuery request,
                                  CancellationToken cancellationToken
                   )
        {
            if (request.CourtGroupName == null)
            {
                return Result.Error("CourtGroupName can be empty string, can not null");
            }

            var bookMarks =
                await _unitOfWork.RepositoryBookMark.GetAllBookMarksByConditionAsync(
                           b => b.CourtGroup != null 
                           && b.CourtGroup.Name != null
                           && b.CourtGroup.Name.Contains(request.CourtGroupName),
                           request.TrackChanges,
                           request.BookMarkParameters,
                           cancellationToken);

            if (!bookMarks.Any())
            {
                return Result.NotFound("There are no courtgroups in bookmark contain that name");
            }

            var bookMarksDto = _mapper.Map<IEnumerable<BookMarkDto>>(bookMarks);

            return Result.Success(bookMarksDto, "Bookmarks are found successfully");
        }
    }
}

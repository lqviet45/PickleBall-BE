using Ardalis.Result;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_BookMark.Queries.GetBookMarkById
{
    internal sealed class GetBookMarkByIdHandler : IRequestHandler<GetBookMarkByIdQuery, Result<BookMarkDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetBookMarkByIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<BookMarkDto>> Handle(GetBookMarkByIdQuery request, CancellationToken cancellationToken)
        {
            var bookMark = await _unitOfWork.RepositoryBookMark.GetBookMarkByConditionAsync(
                               b => b.Id == request.Id,
                               request.TrackChanges,
                               cancellationToken);

            if (bookMark is null || bookMark.IsDeleted)
                return Result.NotFound("BookMark not found");

            var bookMarkDto = _mapper.Map<BookMarkDto>(bookMark);

            return Result.Success(bookMarkDto, "BookMark is found successfully");
        }
    }
}

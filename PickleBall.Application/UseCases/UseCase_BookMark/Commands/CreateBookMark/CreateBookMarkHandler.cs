using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_BookMark.Commands.CreateBookMark
{
    internal sealed class CreateBookMarkHandler : IRequestHandler<CreateBookMarkCommand, Result<BookMarkDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateBookMarkHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<BookMarkDto>> Handle(CreateBookMarkCommand request, CancellationToken cancellationToken)
        {
            var bookMark = await _unitOfWork.RepositoryBookMark.GetEntitiesByConditionAsync(
                               b => b.UserId == request.UserId && b.CourtGroupId == request.CourtId,
                               false,
                               cancellationToken);

            if (bookMark.Any())
                return Result.Error("This bookmark is already existed");

            var user = await _unitOfWork.RepositoryApplicationUser.GetEntityByConditionAsync(
                u => u.Id == request.UserId, false, cancellationToken);

            if (user is null)
                return Result.NotFound("User is not found");

            var courtGroup = await _unitOfWork.RepositoryCourtGroup.GetEntityByConditionAsync(
                c => c.Id == request.CourtId, false, cancellationToken);

            if (courtGroup is null)
                return Result.NotFound("CourtGroup is not found");

            var newBookMark = new BookMark
            {
                UserId = user.Id,
                CourtGroupId = courtGroup.Id,
                CreatedOnUtc = DateTimeOffset.UtcNow
            };

            _unitOfWork.RepositoryBookMark.AddAsync(newBookMark);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            newBookMark.CourtGroup = courtGroup;
            newBookMark.User = user;

            var bookMarkDto = _mapper.Map<BookMarkDto>(newBookMark);

            return Result.Success(bookMarkDto, "bookMark is created successfully!");
        }
    }
}

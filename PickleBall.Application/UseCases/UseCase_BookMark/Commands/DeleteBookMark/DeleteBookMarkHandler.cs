using Ardalis.Result;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;

namespace PickleBall.Application.UseCases.UseCase_BookMark.Commands.DeleteBookMark
{
    internal sealed class DeleteBookMarkHandler : IRequestHandler<DeleteBookMarkCommand, Result>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteBookMarkHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result> Handle(DeleteBookMarkCommand request, CancellationToken cancellationToken)
        {
            var bookMark = await _unitOfWork.RepositoryBookMark.GetBookMarkByConditionAsync(
                b => b.Id == request.Id, false, cancellationToken);

            if (bookMark is null)
                return Result.NotFound("BookMark is not found");

            if (bookMark.IsDeleted)
                return Result.Error("BookMark is already deleted");

            _unitOfWork.RepositoryBookMark.DeleteAsync(bookMark);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Result.SuccessWithMessage("BookMark is deleted successfully");
        }
    }
}

using Ardalis.Result;
using MediatR;
using PickleBall.Application.Abstractions;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Commands.DeleteUser
{
    internal sealed class DeleteUserHandler : IRequestHandler<DeleteUserCommand, Result>
    {
        public readonly IUnitOfWork _unitOfWork;

        public DeleteUserHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.RepositoryApplicationUser.GetEntityByConditionAsync(
                               u => u.Id == request.Id,
                               false,
                               cancellationToken);

            if (user is null)
            {
                return Result.NotFound("User is not found");
            }

            foreach (var courtGroup in user.CourtGroups)
            {
                _unitOfWork.RepositoryCourtGroup.DeleteAsync(courtGroup);
            }

            if (user.Wallets != null)
                _unitOfWork.RepositoryWallet.DeleteAsync(user.Wallets);

            _unitOfWork.RepositoryApplicationUser.DeleteAsync(user);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Result.SuccessWithMessage("User is deleted successfully");
        }
    }
}

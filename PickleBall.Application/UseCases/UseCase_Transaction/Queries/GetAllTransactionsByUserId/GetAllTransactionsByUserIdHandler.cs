using Ardalis.Result;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetAllTransactionsByUserId
{
    internal sealed class GetAllTransactionsByUserIdHandler : IRequestHandler<GetAllTransactionsByUserIdQuery, Result<PagedList<TransactionDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllTransactionsByUserIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<PagedList<TransactionDto>>> Handle(GetAllTransactionsByUserIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.RepositoryApplicationUser.GetEntityByConditionAsync(
                               u => u.Id == request.UserId,
                               request.TrackChanges,
                               cancellationToken);

            if (user == null)
                return Result.NotFound("User is not found");

            var transactions = await _unitOfWork.RepositoryTransaction.GetEntitiesByConditionAsync(
                               t => t.UserId == request.UserId,
                               request.TrackChanges,
                               cancellationToken,
                               t => t.Include(t => t.User));

            if (!transactions.Any())
                return Result.NotFound("Transactions are not found");

            var transactionsDto = _mapper.Map<IEnumerable<TransactionDto>>(transactions.OrderByDescending(t => t.CreatedOnUtc));

            var pagedList = PagedList<TransactionDto>.ToPagedList(
                transactionsDto,
                request.TransactionParameters.PageNumber,
                request.TransactionParameters.PageSize
            );

            return Result.Success(pagedList, "Transactions are found successfully");
        }
    }
}

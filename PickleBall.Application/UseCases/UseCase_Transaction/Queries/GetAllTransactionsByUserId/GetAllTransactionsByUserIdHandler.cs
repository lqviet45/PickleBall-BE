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
                               query => query
                               .IgnoreQueryFilters()
                               .Include(t => t.Booking)
                               .ThenInclude(t => t.CourtGroup));

            if (!transactions.Any())
                return Result.NotFound("Transactions are not found");


            //var transactionsDto = _mapper.Map<IEnumerable<TransactionDto>>(transactions.OrderByDescending(t => t.CreatedOnUtc));

            IEnumerable<TransactionDto> transactionsDto = transactions
                .OrderByDescending(t => t.CreatedOnUtc)
                .Select(t => new TransactionDto
                {
                    Id = t.Id,
                    UserId = t.UserId,
                    WalletId = t.WalletId,
                    DepositId = t.DepositId.HasValue? t.DepositId.Value : Guid.Empty,
                    TransactionStatus = t.TransactionStatus,
                    Amount = t.Amount,
                    Description = t.Description,
                    BookingId = t.BookingId,
                    CreatedOnUtc = t.CreatedOnUtc,
                    ModifiedOnUtc = t.ModifiedOnUtc,
                    CourtGroupName = t.Booking != null && t.Booking.CourtGroup != null ? t.Booking.CourtGroup.Name : string.Empty
                });

            var pagedList = PagedList<TransactionDto>.ToPagedList(
                transactionsDto,
                request.TransactionParameters.PageNumber,
                request.TransactionParameters.PageSize
            );

            return Result.Success(pagedList, "Transactions are found successfully");
        }
    }
}

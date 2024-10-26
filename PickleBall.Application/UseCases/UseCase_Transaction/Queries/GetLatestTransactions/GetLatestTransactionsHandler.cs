using Ardalis.Result;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities.Enums;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetLatestTransactions
{
    internal sealed class GetLatestTransactionsHandler : IRequestHandler<GetLatestTransactionsQuery, Result<PagedList<TransactionDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetLatestTransactionsHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<PagedList<TransactionDto>>> Handle(GetLatestTransactionsQuery request, CancellationToken cancellationToken)
        {
            var transactions = await _unitOfWork.RepositoryTransaction.GetEntitiesByConditionAsync(
                                                t => t.TransactionStatus == TransactionStatus.Completed,
                                              request.TrackChanges,
                                              cancellationToken,
                                               query => query
                                               .IgnoreQueryFilters()
                                               .Include(t => t.User)
                                               .Include(t => t.Booking)
                                               .ThenInclude(t => t.CourtGroup));

            var transProducts = await _unitOfWork.RepositoryTransaction.GetEntitiesByConditionAsync(
                tp => tp.TransactionStatus == TransactionStatus.Completed
                      && tp.BookingId == Guid.Empty,
                request.TrackChanges,
                cancellationToken,
                query => query
                    .IgnoreQueryFilters()
                    .Include(tp => tp.User)
                    .Include(t => t.TransactionProducts)
                    .ThenInclude(tp => tp.Product)
                    .ThenInclude(p => p.CourtGroup)
                );

            transactions = transactions
                .Concat(transProducts)
                .ToList();

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

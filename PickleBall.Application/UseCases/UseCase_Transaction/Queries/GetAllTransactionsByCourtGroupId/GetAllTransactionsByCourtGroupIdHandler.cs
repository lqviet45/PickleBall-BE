using Ardalis.Result;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities.Enums;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetAllTransactionsByCourtGroupId
{
    internal sealed class GetAllTransactionsByCourtGroupIdHandler : IRequestHandler<GetAllTransactionsByCourtGroupIdQuery, Result<PagedList<TransactionDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllTransactionsByCourtGroupIdHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<PagedList<TransactionDto>>> Handle(GetAllTransactionsByCourtGroupIdQuery request, CancellationToken cancellationToken)
        {
            var userId = (await _unitOfWork.RepositoryCourtGroup.GetEntityByConditionAsync(
                            cg => cg.Id == request.CourtGroupId,
                            request.TrackChanges,
                            cancellationToken))?.UserId;
            
            var transactions = await _unitOfWork.RepositoryTransaction.GetEntitiesByConditionAsync(
                               t => t.Booking != null 
                                   && t.TransactionStatus == TransactionStatus.Completed
                                   && t.Booking.CourtGroup != null 
                                   && t.UserId != userId
                                   && t.Booking.CourtGroup.Id == request.CourtGroupId,
                                   request.TrackChanges,
                                   cancellationToken,
                               query => query
                                   .Include(t => t.User)
                                   .Include(t => t.Booking)
                                   .ThenInclude(t => t.CourtGroup));
            
            var transProducts = await _unitOfWork.RepositoryTransaction.GetEntitiesByConditionAsync(
                tp => tp.TransactionStatus == TransactionStatus.Completed
                      && tp.BookingId == Guid.Empty 
                      && tp.UserId != userId,
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
                               request.TransactionParameters.PageSize);

            return Result.Success(pagedList, "Transactions are found successfully");
        }
    }
}

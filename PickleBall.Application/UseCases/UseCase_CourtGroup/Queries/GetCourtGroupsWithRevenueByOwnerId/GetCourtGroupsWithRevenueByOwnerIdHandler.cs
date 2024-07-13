using Ardalis.Result;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;
using PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetRevenueByCourtGroupId;
using PickleBall.Domain.DTOs.CourtGroupsDtos;
using PickleBall.Domain.DTOs.TransactionDtos;
using PickleBall.Domain.Entities.Enums;
using PickleBall.Domain.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetCourtGroupsWithRevenueByOwnerId
{
    internal sealed class GetCourtGroupsWithRevenueByOwnerIdHandler : IRequestHandler<GetCourtGroupsWithRevenueByOwnerIdQuery, Result<PagedList<CourtGroupDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetCourtGroupsWithRevenueByOwnerIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<PagedList<CourtGroupDto>>> Handle(GetCourtGroupsWithRevenueByOwnerIdQuery request, CancellationToken cancellationToken)
        {
            var courtGroups = await _unitOfWork.RepositoryCourtGroup.GetEntitiesByConditionAsync(
                c => c.UserId == request.OwnerId,
                request.TrackChanges,
                cancellationToken,
                c => c.Include(c => c.Medias)
                .Include(c => c.CourtYards)
                .Include(c => c.Ward)
                .ThenInclude(w => w.District)
                .ThenInclude(d => d.City));

            var courtGroupDtos = _mapper.Map<IEnumerable<CourtGroupDto>>(courtGroups);

            foreach (var courtGroupDto in courtGroupDtos)
            {
                courtGroupDto.MonthRevenue = await GetRevenues(courtGroupDto.Id, request, cancellationToken);
            }

            var pagedList = PagedList<CourtGroupDto>.ToPagedList(
                               courtGroupDtos,
                               request.CourtGroupParameters.PageNumber,
                               request.CourtGroupParameters.PageSize);

            return pagedList;
        }

        private async Task<decimal> GetRevenues(
        Guid CourtGroupId,
        GetCourtGroupsWithRevenueByOwnerIdQuery request,
        CancellationToken cancellationToken
    )
        {
            // Get transactions by month, year and courtgroup id
            var transactions = await _unitOfWork.RepositoryTransaction.GetEntitiesByConditionAsync(
                t => t.Booking != null && t.Booking.CourtGroupId == CourtGroupId
                    && t.CreatedOnUtc.Month == request.Month
                    && t.CreatedOnUtc.Year == request.Year
                    && t.TransactionStatus == TransactionStatus.Completed
                    && t.Description == "Booking Income",
                request.TrackChanges,
                cancellationToken,
                t => t.Include(t => t.Booking)
                .OrderByDescending(t => t.CreatedOnUtc));

            var totalRevenueMonth = transactions.Sum(t => t.Amount);


            return totalRevenueMonth;
        }
    }
}

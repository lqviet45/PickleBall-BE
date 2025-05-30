﻿using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs.CourtGroupsDtos;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetCourtGroupsByNameOrCity
{
    internal sealed class GetCourtGroupsByNameOrCityHandler
        : IRequestHandler<GetCourtGroupsByNameOrCityQuery, Result<PagedList<CourtGroupDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetCourtGroupsByNameOrCityHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<PagedList<CourtGroupDto>>> Handle(
            GetCourtGroupsByNameOrCityQuery request,
            CancellationToken cancellationToken
        )
        {
            if (request.Name == null || request.CityName == null)
            {
                return Result.Error("Name and CityName can be empty string, can not null");
            }

            var courtGroups =
                await _unitOfWork.RepositoryCourtGroup.GetAllCourtGroupsByConditionAsync(
                    c =>
                        (
                            c.Name != null
                            && c.Name.Contains(request.Name)
                            && (
                                (request.Name.Trim() == "" && request.CityName.Trim() == "")
                                || request.Name.Trim() != ""
                            )
                        )
                        || (
                            c.Ward != null
                            && c.Ward.District != null
                            && c.Ward.District.City != null
                            && c.Ward.District.City.Name != null
                            && c.Ward.District.City.Name.Contains(request.CityName)
                            && (
                                (request.Name.Trim() == "" && request.CityName.Trim() == "")
                                || request.CityName.Trim() != ""
                            )
                        ),
                    request.TrackChanges,
                    request.CourtGroupParameters,
                    cancellationToken
                );

            if (!courtGroups.Any())
            {
                return Result.NotFound("There are no courtgroups meet this condition");
            }

            var courtGroupsDto = _mapper.Map<IEnumerable<CourtGroupDto>>(courtGroups);

            var pagedList = PagedList<CourtGroupDto>.ToPagedList(
                courtGroupsDto,
                request.CourtGroupParameters.PageNumber,
                request.CourtGroupParameters.PageSize
            );

            return Result.Success(pagedList, "Court groups found");
        }
    }
}

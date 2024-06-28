using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Commands.CreateCourtGroup
{
    internal sealed class CreateCourtGroupHandler
        : IRequestHandler<CreateCourtGroupCommand, Result<CourtGroupDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateCourtGroupHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<CourtGroupDto>> Handle(
            CreateCourtGroupCommand request,
            CancellationToken cancellationToken
        )
        {
            var user = await _unitOfWork.RepositoryApplicationUser.GetUserByConditionAsync(
                u => u.Id == request.UserId,
                false,
                cancellationToken
            );

            if (user is null)
            {
                return Result.NotFound("User is not found");
            }
            Ward? ward;
            try
            {
                ward = await _unitOfWork.RepositoryWard.GetUniqueWardByNameAsync(
                    request.WardName,
                    false,
                    cancellationToken
                );

                if (ward is null)
                {
                    return Result.NotFound("Ward is not found");
                }
            }
            catch (Exception e)
            {
                return Result.Error("There are more than 2 ward with this name");
            }

            var courtGroup = new CourtGroup
            {
                UserId = user.Id,
                WardId = ward.Id,
                Name = request.Name,
                Price = request.Price,
                MinSlots = request.MinSlots,
                MaxSlots = request.MaxSlots,
            };

            if (!string.IsNullOrEmpty(request.MediaUrl))
            {
                var media = new Media
                {
                    MediaUrl = request.MediaUrl,
                    CourtGroupId = courtGroup.Id,
                    CreatedOnUtc = DateTimeOffset.UtcNow
                };
                courtGroup.Medias.Add(media);
            }

            _unitOfWork.RepositoryCourtGroup.AddAsync(courtGroup);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            courtGroup.Ward = ward;
            var courtGroupDto = _mapper.Map<CourtGroupDto>(courtGroup);
            return Result.Success(courtGroupDto, "Court group is created successfully");
        }
    }
}

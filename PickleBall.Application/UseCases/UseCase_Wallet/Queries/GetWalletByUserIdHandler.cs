using Ardalis.Result;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Wallet.Queries
{
    internal sealed class GetWalletByUserIdHandler : IRequestHandler<GetWalletByUserIdQuery, Result<WalletDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetWalletByUserIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<WalletDto>> Handle(GetWalletByUserIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.RepositoryApplicationUser.GetEntityByConditionAsync(
                               u => u.Id == request.UserId,
                               request.TrackChanges,
                               cancellationToken);

            if (user == null)
                return Result.NotFound("User not found");

            var wallet = await _unitOfWork.RepositoryWallet.GetEntityByConditionAsync(
                w => w.UserId == request.UserId,
                request.TrackChanges,
                cancellationToken,
                w => w.Include(w => w.Transactions)
                .Include(w => w.Deposits));

            if (wallet is null)
                return Result.NotFound("Wallet not found");

            var walletDto = _mapper.Map<WalletDto>(wallet);

            return Result.Success(walletDto, "Wallet found successfully");
        }
    }
}

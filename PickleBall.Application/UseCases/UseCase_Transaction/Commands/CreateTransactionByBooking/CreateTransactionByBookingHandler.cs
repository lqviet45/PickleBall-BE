// using Ardalis.Result;
// using AutoMapper;
// using MediatR;
// using PickleBall.Application.Abstractions;
// using PickleBall.Domain.DTOs;

// namespace PickleBall.Application.UseCases.UseCase_Transaction.Commands.CreateTransactionByBooking;

// internal sealed class CreateTransactionByBookingHandler(IUnitOfWork unitOfWork, IMapper mapper)
//     : IRequestHandler<CreateTransactionByBookingCommand, Result<TransactionDto>>
// {
//     public async Task<Result<TransactionDto>> Handle(
//         CreateTransactionByBookingCommand request,
//         CancellationToken cancellationToken
//     )
//     {
//         var ValidateId = await IsValidateId(unitOfWork, request, cancellationToken);
//         if (!ValidateId.IsSuccess)
//             return ValidateId;

//         return await AddTransactionToDb(unitOfWork, mapper, ValidateId, cancellationToken);
//     }

//     private static async Task<Result<TransactionDto>> IsValidateId(
//         IUnitOfWork unitOfWork,
//         CreateTransactionByBookingCommand request,
//         CancellationToken cancellationToken
//     )
//     {
//         // Check if user exists
//         var user = await unitOfWork.RepositoryApplicationUser.GetUserByIdAsync(
//             request.UserId,
//             false,
//             cancellationToken
//         );
//         if (user is null)
//             return Result.NotFound("User not found");

//         // Check if wallet exists
//         var wallet = await unitOfWork.RepositoryWallet.GetEntityByConditionAsync(
//             x => x.UserId == request.UserId,
//             false,
//             cancellationToken
//         );
//         if (wallet is null)
//             return Result.NotFound("Wallet not found");

//         // Check if court group exists
//         var courtGroup = await unitOfWork.RepositoryCourtGroup.GetEntityByConditionAsync(
//             x => x.Id == request.CourtGroupId,
//             false,
//             cancellationToken
//         );
//         if (courtGroup is null)
//             return Result.NotFound("Court group not found");

//         // Check if booking exists
//         // var booking = await unitOfWork.RepositoryBooking.GetEntityByConditionAsync(
//         //     x => x.Id == request.BookingId,
//         //     false,
//         //     cancellationToken
//         // );
//         // if (booking is null)
//         //     return Result.NotFound("Booking not found");

//         TransactionDto transactionDto =
//             new()
//             {
//                 UserId = user.Id,
//                 WalletId = wallet.Id,
//                 BookingId = request.BookingId,
//                 Amount = courtGroup.Price,
//             };

//         return Result.Success(transactionDto);
//     }

//     private static async Task<Result<TransactionDto>> AddTransactionToDb(
//         IUnitOfWork unitOfWork,
//         IMapper mapper,
//         TransactionDto request,
//         CancellationToken cancellationToken
//     )
//     {
//         var wallet = await unitOfWork.RepositoryWallet.GetEntityByConditionAsync(
//             x => x.Id == request.WalletId,
//             false,
//             cancellationToken
//         );
//         wallet.Balance -= request.Amount;

//         Transaction transaction =
//             new()
//             {
//                 UserId = request.UserId,
//                 WalletId = request.WalletId,
//                 BookingId = request.BookingId,
//                 Amount = request.Amount,
//                 Description = "Booking",
//                 TransactionStatus = TransactionStatus.Pending,
//                 CreatedOnUtc = DateTimeOffset.UtcNow
//             };

//         unitOfWork.RepositoryTransaction.AddAsync(transaction);
//         unitOfWork.RepositoryWallet.UpdateAsync(wallet);

//         await unitOfWork.SaveChangesAsync(cancellationToken);

//         var transactionDto = mapper.Map<TransactionDto>(transaction);

//         return Result.Success(transactionDto);
//     }
// }

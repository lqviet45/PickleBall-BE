using Ardalis.Result;
using MediatR;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetTotalUser;

public class GetTotalUserQuery : IRequest<Result<int>>
{
}
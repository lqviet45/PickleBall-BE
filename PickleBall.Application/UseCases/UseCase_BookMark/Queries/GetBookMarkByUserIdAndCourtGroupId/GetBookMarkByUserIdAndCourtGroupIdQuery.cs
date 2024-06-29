using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_BookMark.Queries.GetBookMarkByUserIdAndCourtGroupId
{
    public class GetBookMarkByUserIdAndCourtGroupIdQuery : IRequest<Result<BookMarkDto>>
    {
        public Guid UserId { get; set; }
        public Guid CourtGroupId { get; set; }
    }
}

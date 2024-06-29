using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_BookMark.Queries.GetAllBookMarkByUserId
{
    public class GetAllBookMarkByUserIdQuery : IRequest<Result<IEnumerable<BookMarkDto>>>
    {
        public Guid Id { get; set; }
        public bool TrackChanges { get; init; } = false;
        public BookMarkParameters BookMarkParameters { get; set; } = new();
    }
}

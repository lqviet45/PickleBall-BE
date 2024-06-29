using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_BookMark.Queries.GetAllBookMark
{
    public class GetAllBookMarkQuery : IRequest<Result<IEnumerable<BookMarkDto>>>
    {
        public bool TrackChanges { get; init; } = false;
        public BookMarkParameters BookMarkParameters { get; set; } = new();
    }
}

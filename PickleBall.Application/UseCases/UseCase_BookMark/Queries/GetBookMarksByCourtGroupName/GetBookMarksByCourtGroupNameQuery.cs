using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_BookMark.Queries.GetBookMarksByCourtGroupName
{
    public class GetBookMarksByCourtGroupNameQuery : IRequest<Result<IEnumerable<BookMarkDto>>>
    {
        public string CourtGroupName { get; set; } = string.Empty;
        public bool TrackChanges { get; set; } = false;
    }
}

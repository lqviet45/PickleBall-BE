using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_BookMark.Queries.GetBookMarkById
{
    public class GetBookMarkByIdQuery : IRequest<Result<BookMarkDto>>
    {
        public Guid Id { get; set; }

        public bool TrackChanges { get; set; } = false;
    }
}

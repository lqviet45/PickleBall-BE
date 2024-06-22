using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Media.Queries.GetMediasByUserId
{
    public class GetMediasByUserIdQuery : IRequest<Result<IEnumerable<MediaDto>>>
    {
        public Guid UserId { get; set; }
        public bool TrackChanges { get; set; } = false;
    }
}

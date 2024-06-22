using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Ward.Queries.GetAllWards
{
    public class GetAllWardQuery : IRequest<Result<IEnumerable<WardDto>>>
    {
        public bool TrackChanges { get; set; } = false;
    }
}

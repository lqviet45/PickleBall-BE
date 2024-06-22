using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Ward.Queries.GetWardsByName
{
    public class GetWardsByNameQuery : IRequest<Result<IEnumerable<WardDto>>>
    {
        public string Name { get; set; } = string.Empty;
        public bool TrackChanges { get; set; } = false;
    }
}

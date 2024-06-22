using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Ward.Queries.GetWardById
{
    public class GetWardByIdQuery : IRequest<Result<WardDto>>
    {
        public Guid Id { get; set; }
        public bool TrackChanges { get; set; } = false;
    }
}

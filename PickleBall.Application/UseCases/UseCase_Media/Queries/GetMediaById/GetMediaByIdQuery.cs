using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Media.Queries.GetMediaById
{
    public class GetMediaByIdQuery : IRequest<Result<MediaDto>>
    {
        public Guid Id { get; set; }
        public bool trackChanges { get; set; } = false;
    }
}

using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_District.Queries.GetDistrictById;

public class GetDistrictByIdQuery : IRequest<Result<DistrictDto>>
{
    public int Id { get; set; }
    public bool TrackChanges { get; set; } = false;
}

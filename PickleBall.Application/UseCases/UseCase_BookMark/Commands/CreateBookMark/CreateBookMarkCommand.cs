using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_BookMark.Commands.CreateBookMark
{
    public class CreateBookMarkCommand : IRequest<Result<BookMarkDto>>
    {
        public Guid UserId { get; set; }
        public Guid CourtId { get; set; }
    }
}

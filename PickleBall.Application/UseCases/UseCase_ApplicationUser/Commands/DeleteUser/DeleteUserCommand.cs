using Ardalis.Result;
using MediatR;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Commands.DeleteUser
{
    public class DeleteUserCommand : IRequest<Result>
    {
        public Guid Id { get; set; }
    }
}

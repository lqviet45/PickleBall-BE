using Ardalis.Result;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickleBall.Application.UseCases.UseCase_BookMark.Commands.DeleteBookMark
{
    public class DeleteBookMarkCommand : IRequest<Result>
    {
        public Guid Id { get; set; }
    }
}

using Ardalis.Result;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Commands.DeleteCourtGroup
{
    public class DeleteCourtGroupCommand : IRequest<Result>
    {
        public Guid Id { get; set; }
    }
}

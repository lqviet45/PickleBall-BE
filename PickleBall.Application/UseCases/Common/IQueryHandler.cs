namespace PickleBall.Application.UseCases.Common;

public interface IQueryHandler<in TCommand, TCommandResult>
{
    Task<TCommandResult> Handle(TCommand command, CancellationToken cancellation);
}

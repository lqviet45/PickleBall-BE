namespace PickleBall.Application.UseCases.Common;

public interface ICommandDispatcher
{
    Task<TCommandResult> Dispatch<TCommand, TCommandResult>(
        TCommand command,
        CancellationToken cancellation
    );
}

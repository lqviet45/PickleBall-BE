using Microsoft.Extensions.DependencyInjection;
using PickleBall.Application.UseCases.Common;

namespace PickleBall.Application.UseCases.Dispatchers;

public class CommandDispatcher : ICommandDispatcher
{
    private readonly IServiceProvider _serviceProvider;

    public CommandDispatcher(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public Task<TCommandResult> Dispatch<TCommand, TCommandResult>(
        TCommand command,
        CancellationToken cancellation
    )
    {
        var handler = _serviceProvider.GetRequiredService<
            ICommandHandler<TCommand, TCommandResult>
        >();
        return handler.Handle(command, cancellation);
    }
}

using Microsoft.Extensions.DependencyInjection;
using PickleBall.Application.Abstractions;

namespace PickleBall.Infrastructure;

public static class DependencyInjection
{
    public static void AddUseCases(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly)
        );
    }
}

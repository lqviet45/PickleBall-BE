using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PickleBall.Application.Abstractions;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Infrastructure.Data.Repositories;
using PickleBall.Persistence.Data;
using PickleBall.Persistence.Data.Repositories;

namespace PickleBall.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        // Add DB Context
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
        );

        // Add other services

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}

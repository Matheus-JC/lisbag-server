using LisbagServer.Domain.Interfaces.Repositories;
using LisbagServer.Infra.Dal.Context;
using LisbagServer.Infra.Dal.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LisbagServer.Infra.DI;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ProfileDbContext>(options =>
            options
                .UseNpgsql(
                    configuration.GetConnectionString("PostgresConn"),
                    b => b.MigrationsAssembly(typeof(ProfileDbContext).Assembly.FullName)
                )
                .UseSnakeCaseNamingConvention()
        );

        services.AddScoped<IProfileRepository, ProfileRepository>();

        return services;
    }
}

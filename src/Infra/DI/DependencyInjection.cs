using LisbagServer.Application.Interfaces;
using LisbagServer.Application.Mappings;
using LisbagServer.Application.Services;
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
        services.AddDbContext<UserProfileDbContext>(options =>
            options
                .UseNpgsql(
                    configuration.GetConnectionString("PostgresConn"),
                    b => b.MigrationsAssembly(typeof(UserProfileDbContext).Assembly.FullName)
                )
                .UseSnakeCaseNamingConvention()
        );

        services.AddScoped<IUserProfileRepository, UserProfileRepository>();

        services.AddScoped<IUserProfileService, UserProfileService>();

        services.AddAutoMapper(typeof(DomainToDTOMappingProfile));
        services.AddAutoMapper(typeof(TypeConversionMappingProfile));

        return services;
    }
}

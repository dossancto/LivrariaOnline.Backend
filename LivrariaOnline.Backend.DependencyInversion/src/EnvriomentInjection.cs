using DotNetEnv;
using LivrariaOnline.Backend.Infra.Database.EF.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace LivrariaOnline.Backend.DependencyInversion;

public static class EnvriomentInjection
{
    public static IServiceCollection AddEnvironment(this IServiceCollection services)
    {
        Env.TraversePath().Load();

        services.AddScoped<ApplicationDbContext>();

        return services;
    }
}


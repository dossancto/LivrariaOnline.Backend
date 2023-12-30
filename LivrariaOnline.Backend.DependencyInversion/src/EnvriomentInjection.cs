using DotNetEnv;
using LivrariaOnline.Backend.Infra.Database;
using Microsoft.Extensions.DependencyInjection;

namespace LivrariaOnline.Backend.DependencyInversion;

public static class EnvriomentInjection
{
    public static IServiceCollection AddEnvironment(this IServiceCollection services)
    {
        Env.TraversePath().Load();

        services.AddDatabase();

        return services;
    }
}


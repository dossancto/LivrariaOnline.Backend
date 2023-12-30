using LivrariaOnline.Backend.Adapters.Providers;
using LivrariaOnline.Backend.Infra.Providers.Cryptographys;
using Microsoft.Extensions.DependencyInjection;

namespace LivrariaOnline.Backend.DependencyInversion;

public static class ProvidersInjection
{
    public static IServiceCollection AddProviders(this IServiceCollection services)
    {
        services.AddTransient<ICryptographysNoSalt, BCryptProvider>();

        return services;
    }
}


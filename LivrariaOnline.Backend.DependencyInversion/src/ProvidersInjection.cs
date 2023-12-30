using LivrariaOnline.Backend.Adapters.Providers;
using LivrariaOnline.Backend.DependencyInversion.Providers;
using LivrariaOnline.Backend.Infra.Providers.Cryptographys;
using Microsoft.Extensions.DependencyInjection;

namespace LivrariaOnline.Backend.DependencyInversion;

public static class ProvidersInjection
{
    public static IServiceCollection AddProviders(this IServiceCollection services, bool developmentMode = true)
    {
        services.AddTransient<ICryptographysNoSalt, BCryptProvider>();

        services.AddEmailSender(developmentMode);

        return services;
    }
}


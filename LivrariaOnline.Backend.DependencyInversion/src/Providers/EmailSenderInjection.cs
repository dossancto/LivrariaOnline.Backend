using LivrariaOnline.Backend.Adapters.Apis;
using LivrariaOnline.Backend.Infra.APIs.EmailSender;
using Microsoft.Extensions.DependencyInjection;

namespace LivrariaOnline.Backend.DependencyInversion.Providers;

public static class EmailSenderInjection
{
    internal static IServiceCollection AddEmailSender(this IServiceCollection services, bool developmentMode = true)
    {
        if (developmentMode)
        {
            services.AddLocalEmailSender();
        }
        else
        {
            services.AddRealEmailSender();
        }

        return services;
    }

    private static IServiceCollection AddLocalEmailSender(this IServiceCollection services)
    {
        services.AddScoped<IEmailSender, DevelopmentEmailSender>();

        return services;
    }

    private static IServiceCollection AddRealEmailSender(this IServiceCollection services)
    {
        services.AddScoped<IEmailSender, LivrariaOnlineEmailSender>();

        return services;
    }
}


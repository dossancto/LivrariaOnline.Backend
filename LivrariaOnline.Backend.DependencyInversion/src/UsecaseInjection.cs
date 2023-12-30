using LivrariaOnline.Backend.Application.App.Users.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace LivrariaOnline.Backend.DependencyInversion;

public static class UsecaseInjection
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        services.AddScoped<RegisterUserUseCase>();
        services.AddScoped<LoginUserUseCase>();
        // services.AddScoped<SendEmailConfirmCodeUseCase>();

        return services;
    }
}


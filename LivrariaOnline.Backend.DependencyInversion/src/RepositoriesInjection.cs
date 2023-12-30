using LivrariaOnline.Backend.Application.App.Users.Data;
using LivrariaOnline.Backend.Infra.Database;
using LivrariaOnline.Backend.Infra.Database.EF.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace LivrariaOnline.Backend.DependencyInversion;

public static class RepositoriesInjection
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddDatabase();

        services.AddTransient<IUserRepository, EFUserRepository>();
        services.AddTransient<IUserConfirmationRepository, EFEmailConfirmationRepository>();

        return services;
    }
}


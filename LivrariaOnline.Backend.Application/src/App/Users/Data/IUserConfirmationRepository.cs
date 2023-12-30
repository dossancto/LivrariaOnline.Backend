using LivrariaOnline.Backend.Application.App.Users.Entities;

namespace LivrariaOnline.Backend.Application.App.Users.Data;

public interface IUserConfirmationRepository
{
    Task<EmailConfirmationEntity> Save(EmailConfirmationEntity user);

    Task<EmailConfirmationEntity?> GetByCode(string code, string userId);

    Task ConfirmCode(string code, string userId);
}

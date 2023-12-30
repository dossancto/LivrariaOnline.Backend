using LivrariaOnline.Backend.Application.App.Users.Entities;

namespace LivrariaOnline.Backend.Application.App.Users.Data;

public interface IUserRepository
{
    Task<UserEntity> Save(UserEntity user);

    Task<UserEntity?> FindById(string id);
    Task<UserEntity?> FindByEmail(string email);

    Task ConfirmEmail(string code, string userId);
}

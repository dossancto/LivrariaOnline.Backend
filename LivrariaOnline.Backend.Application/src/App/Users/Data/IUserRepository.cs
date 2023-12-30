using LivrariaOnline.Backend.Application.App.Users.Entities;

namespace LivrariaOnline.Backend.Application.App.Users.Data;

public interface IUserRepository
{
    Task<UserEntity> Save(UserEntity user);

    Task<UserEntity> FindById(UserEntity user);
    Task<UserEntity> FindByEmail(UserEntity user);

    Task ConfirmEmail(string code, string userId);

    Task<UserEntity> Login(string emailOrUser, string password);
}

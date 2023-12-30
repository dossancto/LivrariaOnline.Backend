using LivrariaOnline.Backend.Adapters.Providers;
using LivrariaOnline.Backend.Application.App.Users.Data;
using LivrariaOnline.Backend.Application.App.Users.Entities;

namespace LivrariaOnline.Backend.Application.App.Users.UseCases;

public class LoginUserUseCase
{
    public record SimpleLogin(string userOrEmail, string Password);

    public readonly IUserRepository _userRepository;
    public readonly ICryptographysNoSalt _cryptographys;

    public LoginUserUseCase(IUserRepository userRepository, ICryptographysNoSalt cryptographys)
    {
        _userRepository = userRepository;
        _cryptographys = cryptographys;
    }

    public async Task Execute(SimpleLogin userDto)
    {
        var user = await _userRepository.FindByEmail(userDto.userOrEmail);

        if (user is null)
        {
            // FIX: Throw the correct exception.
            throw new Exception("User not found.");
        }

        var correctPassword = _cryptographys.Verify(userDto.Password, user.HashedPassword);

        if (!correctPassword)
        {
            throw new Exception("email or password invalid");
        }
    }
}

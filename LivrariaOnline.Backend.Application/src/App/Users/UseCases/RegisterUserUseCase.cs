using LivrariaOnline.Backend.Adapters.Providers;
using LivrariaOnline.Backend.Application.App.Users.Data;
using LivrariaOnline.Backend.Application.App.Users.Entities;

namespace LivrariaOnline.Backend.Application.App.Users.UseCases;

public class RegisterUserUseCase
{
    public record SimpleRegister(string Email, string Name, string Password, DateTime BirthDate);

    public readonly IUserRepository _userRepository;
    // public readonly ICryptographys _cryptographys;
    // public readonly SendEmailConfirmCodeUseCase _sendConfirmation;

    public RegisterUserUseCase(IUserRepository userRepository)
    {
        _userRepository = userRepository;
        // _cryptographys = cryptographys;
        // _sendConfirmation = sendConfirmation;
    }

    public async Task<UserEntity> Execute(SimpleRegister userDto)
    {
        var user = UserDtoToModel(userDto);

        // var (hashedPasword, salt) = _cryptographys.HashPassword(userDto.Password);

        user.HashedPassword = userDto.Password;
        user.Salt = "seguro sim";

        user.Roles = new() { "User" };

        var registedUser = await _userRepository.Save(user);

        // await _sendConfirmation.Execute(userDto.Email);

        return registedUser;
    }

    private UserEntity UserDtoToModel(SimpleRegister x)
    => new()
    {
        Email = x.Email,
        Name = x.Name,
        BirthDate = x.BirthDate,
    };
}

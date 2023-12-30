using LivrariaOnline.Backend.Adapters.Apis;
using LivrariaOnline.Backend.Application.App.Users.Data;
using NanoidDotNet;

namespace LivrariaOnline.Backend.Application.App.Users.UseCases;

public class ConfirmEmailCodeUseCase
{
    public readonly IUserConfirmationRepository _confirmCodeRepository;
    public readonly IUserRepository _userRepository;

    public ConfirmEmailCodeUseCase(IUserConfirmationRepository confirmCodeRepository, IUserRepository userRepository)
    {
        _confirmCodeRepository = confirmCodeRepository;
        _userRepository = userRepository;
    }

    public async Task Execute(string targetEmail)
    {
    }
}

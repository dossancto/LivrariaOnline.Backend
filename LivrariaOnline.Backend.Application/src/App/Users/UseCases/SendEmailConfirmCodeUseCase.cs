using LivrariaOnline.Backend.Adapters.Apis;
using LivrariaOnline.Backend.Application.App.Users.Data;
using NanoidDotNet;

namespace LivrariaOnline.Backend.Application.App.Users.UseCases;

public class SendEmailConfirmCodeUseCase
{
    public readonly IEmailSender _emailSender;
    public readonly IUserConfirmationRepository _confirmCodeRepository;
    public readonly IUserRepository _userRepository;

    public readonly int CODE_SIZE = 4;

    public SendEmailConfirmCodeUseCase(IEmailSender emailSender, IUserConfirmationRepository confirmCodeRepository, IUserRepository userRepository)
    {
        _emailSender = emailSender;
        _confirmCodeRepository = confirmCodeRepository;
        _userRepository = userRepository;
    }

    public async Task Execute(string targetEmail)
    {
        var code = Nanoid.Generate("1234567890", size: CODE_SIZE);

        await _emailSender.SendEmailConfirmationCode(targetEmail, code);
    }
}

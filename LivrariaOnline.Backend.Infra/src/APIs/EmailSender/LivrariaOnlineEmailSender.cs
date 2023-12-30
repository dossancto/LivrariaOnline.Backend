using LivrariaOnline.Backend.Adapters.Apis;

namespace LivrariaOnline.Backend.Infra.APIs.EmailSender;

public class LivrariaOnlineEmailSender : IEmailSender
{
    public Task SendEmailConfirmationCode(string targetEmail, string code)
    {
        throw new NotImplementedException();
    }

    public class Configuration { }
}

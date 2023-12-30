namespace LivrariaOnline.Backend.Adapters.Apis;

public interface IEmailSender
{
    Task SendEmailConfirmationCode(string targetEmail, string code);
}

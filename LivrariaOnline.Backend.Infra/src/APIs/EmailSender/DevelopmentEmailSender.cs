using LivrariaOnline.Backend.Adapters.Apis;
using Microsoft.Extensions.Logging;

namespace LivrariaOnline.Backend.Infra.APIs.EmailSender;

public class DevelopmentEmailSender : IEmailSender
{
    public class Configuration { }

    private readonly ILogger<DevelopmentEmailSender> _logger;

    public DevelopmentEmailSender(ILogger<DevelopmentEmailSender> logger)
    {
        _logger = logger;
    }

    public Task SendEmailConfirmationCode(string targetEmail, string code)
    {
        var msg = $"Email code for \"{targetEmail}\" is -> {code} <- ";

        _logger.LogInformation(msg);

        return Task.CompletedTask;
    }
}

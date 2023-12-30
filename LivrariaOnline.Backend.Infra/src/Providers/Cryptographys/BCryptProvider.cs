using LivrariaOnline.Backend.Adapters.Providers;

namespace LivrariaOnline.Backend.Infra.Providers.Cryptographys;

public class BCryptProvider : ICryptographysNoSalt
{
    public string HashPassword(string password)
      => BCrypt.Net.BCrypt.HashPassword(password);

    public bool Verify(string password, string hasedPassword)
      => BCrypt.Net.BCrypt.Verify(password, hasedPassword);
}

namespace LivrariaOnline.Backend.Adapters.Providers;

public interface ICryptographysNoSalt
{
    string HashPassword(string password);
    bool Verify(string password, string hasedPassword);
}

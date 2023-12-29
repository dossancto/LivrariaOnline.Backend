using LivrariaOnline.Backend.Application.App.Users.Enum;

namespace LivrariaOnline.Backend.Application.App.Users.Entities;

public class UserEntity
{
    public string Id { get; set; } = default!;

    public string Name { get; set; } = default!;

    public string Email { get; set; } = default!;
    public EmailConfirmationStatus EmailStatus { get; set; } = default!;

    public string HashedPassword { get; set; } = default!;
    public string Salt { get; set; } = default!;

    public List<string> Roles { get; set; } = default!;

    public UserAddressEntity? Address { get; set; }
    public DateTime BirthDate { get; set; } = DateTime.UtcNow;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}

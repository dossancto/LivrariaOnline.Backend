using LivrariaOnline.Backend.Application.App.Users.Enum;

namespace LivrariaOnline.Backend.Application.App.Users.Entities;

public class EmailConfirmationEntity
{
    public string Id { get; set; } = default!;

    public string Code { get; set; } = default!;

    public DateTime ValidTill { get; set; }

    public DateTime GeneratedAt { get; set; } = DateTime.UtcNow;

    public EmailConfirmationGenerationType GenerationType { get; set; }

    public UserEntity User { get; set; } = default!;

    public bool Expired { get; set; }

    public bool Confirmed { get; set; }
    public DateTime? ConfirmedAt { get; set; }
}

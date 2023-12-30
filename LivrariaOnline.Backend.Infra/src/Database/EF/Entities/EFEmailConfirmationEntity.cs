using LivrariaOnline.Backend.Application.App.Users.Entities;
using LivrariaOnline.Backend.Infra.Utils;

namespace LivrariaOnline.Backend.Infra.Database.EF.Entities;

public class EFEmailConfirmationEntity : EmailConfirmationEntity
{
    public string UserId { get; set; } = default!;
    public new EFUserEntity User { get; set; } = default!;

    public EFEmailConfirmationEntity(EmailConfirmationEntity x)
    {
        Id = x.Id ?? IdGenerator.GenerateId();

        Code = x.Code;
        ValidTill = x.ValidTill;
        GenerationType = x.GenerationType;

        User = new(x.User);

        UserId = User.Id;

        GeneratedAt = x.GeneratedAt;

        Confirmed = x.Confirmed;

        Expired = DateTime.UtcNow >= ValidTill;

        ConfirmedAt = x.ConfirmedAt;
    }
}

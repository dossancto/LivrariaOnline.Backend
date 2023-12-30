using LivrariaOnline.Backend.Application.App.Users.Entities;
using LivrariaOnline.Backend.Infra.Utils;
using Newtonsoft.Json;

namespace LivrariaOnline.Backend.Infra.Database.EF.Entities;

public class EFUserEntity : UserEntity
{
    public string RolesJson { get; set; } = "[]";

    public string? AddressId { get; set; } = default!;

    public new EFUserAddressEntity Address { get; set; } = default!;

    public new DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public EFUserEntity() { }

    public EFUserEntity(UserEntity x)
    {
        Id = IdGenerator.GenerateId();
        Name = x.Name;
        Email = x.Email;
        EmailStatus = x.EmailStatus;
        HashedPassword = x.HashedPassword;
        Salt = x.Salt;
        Roles = x.Roles;
        RolesJson = JsonConvert.SerializeObject(Roles);

        BirthDate = x.BirthDate;

        CreatedAt = x.CreatedAt;
        UpdatedAt = x.UpdatedAt;

        if (x.Address is not null)
        {
            Address = new(x.Address);
            AddressId = Address.Id;
        }
    }
}

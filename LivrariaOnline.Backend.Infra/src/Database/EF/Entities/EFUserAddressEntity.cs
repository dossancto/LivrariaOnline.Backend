using LivrariaOnline.Backend.Application.App.Users.Entities;
using LivrariaOnline.Backend.Infra.Utils;

namespace LivrariaOnline.Backend.Infra.Database.EF.Entities;

public class EFUserAddressEntity : UserAddressEntity
{
    public string Id { get; set; } = default!;

    public EFUserEntity User { get; set; } = default!;

    public EFUserAddressEntity(){}

    public EFUserAddressEntity(UserAddressEntity x)
    {
        Id = IdGenerator.GenerateId();
        Address = x.Address;
        CEP = x.CEP;
        City = x.City;

        Longitude = x.Longitude;
        Latitude = x.Latitude;
    }
}

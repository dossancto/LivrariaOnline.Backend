namespace LivrariaOnline.Backend.Application.App.Users.Entities;

public class UserAddressEntity
{
    public string Address { get; set; } = default!;
    public string CEP { get; set; } = default!;
    public string City { get; set; } = default!;

    public string Latitude { get; set; } = default!;
    public string Longitude { get; set; } = default!;
}

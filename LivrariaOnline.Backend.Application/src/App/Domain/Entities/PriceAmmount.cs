namespace LivrariaOnline.Backend.Application.App.Domain.Entities;

public class PriceAmmount
{
    public decimal Price { get; set; }
    public string Currency { get; set; } = default!;
}

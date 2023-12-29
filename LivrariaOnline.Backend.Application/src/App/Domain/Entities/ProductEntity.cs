using LivrariaOnline.Backend.Application.App.Domain.Enums;

namespace LivrariaOnline.Backend.Application.App.Domain.Entities;

public class ProductEntity
{
    public int StockQuantity { get; set; }

    public PriceAmmount Ammount { get; set; } = default!;

    public ProductAvaibitilyStatus Avaible { get; set; }
}

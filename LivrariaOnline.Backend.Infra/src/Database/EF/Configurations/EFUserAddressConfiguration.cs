using LivrariaOnline.Backend.Infra.Database.EF.Entities;
using LivrariaOnline.Backend.Infra.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LivrariaOnline.Backend.Infra.Database.EF.Configurations;

public class EFUserAddressConfiguration : IEntityTypeConfiguration<EFUserAddressEntity>
{
    public void Configure(EntityTypeBuilder<EFUserAddressEntity> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.Property(x => x.Id).HasMaxLength(IdGenerator.ID_SIZE);

        builder.Property(x => x.CEP).IsRequired().HasMaxLength(9);

        builder.Property(x => x.City).IsRequired().HasMaxLength(30);
        builder.Property(x => x.Address).IsRequired().HasMaxLength(80);

        builder.HasOne(a => a.User)
          .WithOne(b => b.Address);
    }
}

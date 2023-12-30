using LivrariaOnline.Backend.Infra.Database.EF.Entities;
using LivrariaOnline.Backend.Infra.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LivrariaOnline.Backend.Infra.Database.EF.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<EFUserEntity>
{
    public void Configure(EntityTypeBuilder<EFUserEntity> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.Property(x => x.Id).HasMaxLength(IdGenerator.ID_SIZE);

        builder.Property(x => x.Name).IsRequired().HasMaxLength(80);

        builder.Property(x => x.Email).IsRequired();
        builder.Property(x => x.Email).HasMaxLength(90);
        builder.HasIndex(x => x.Email).IsUnique();

        builder.Property(x => x.HashedPassword).IsRequired();
        builder.Property(x => x.Salt).IsRequired();

        builder.Property(x => x.BirthDate).IsRequired();

        builder.Ignore(x => x.Roles);

        builder.Property(x => x.CreatedAt).ValueGeneratedOnAdd();
        builder.Property(x => x.UpdatedAt).ValueGeneratedOnAdd();
    }
}

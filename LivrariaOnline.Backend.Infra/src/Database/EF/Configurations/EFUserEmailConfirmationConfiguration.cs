using LivrariaOnline.Backend.Infra.Database.EF.Entities;
using LivrariaOnline.Backend.Infra.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LivrariaOnline.Backend.Infra.Database.EF.Configurations;

public class EFUserEmailConfirmationConfiguration : IEntityTypeConfiguration<EFEmailConfirmationEntity>
{
    public void Configure(EntityTypeBuilder<EFEmailConfirmationEntity> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.Property(x => x.Id).HasMaxLength(IdGenerator.ID_SIZE);

        builder.Property(x => x.ValidTill).IsRequired();

        builder.Property(x => x.Code).IsRequired();
        builder.HasIndex(x => x.Code);

        builder.Property(x => x.GeneratedAt).ValueGeneratedOnAdd();

        builder.HasOne(x => x.User)
               .WithMany()
               .HasForeignKey(x => x.UserId);
    }
}

using LivrariaOnline.Backend.Infra.Database.EF.Entities;
using Microsoft.EntityFrameworkCore;

namespace LivrariaOnline.Backend.Infra.Database.EF.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options) { }

    public DbSet<EFUserEntity> Users { get; set; } = default!;
    public DbSet<EFUserAddressEntity> UserAddress { get; set; } = default!;
    public DbSet<EFEmailConfirmationEntity> UserEmailConfirmation { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}

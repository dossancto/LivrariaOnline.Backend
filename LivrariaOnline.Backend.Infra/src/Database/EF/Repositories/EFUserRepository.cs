using LivrariaOnline.Backend.Application.App.Users.Data;
using LivrariaOnline.Backend.Application.App.Users.Entities;
using LivrariaOnline.Backend.Application.App.Users.Enum;
using LivrariaOnline.Backend.Infra.Database.EF.Contexts;
using LivrariaOnline.Backend.Infra.Database.EF.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace LivrariaOnline.Backend.Infra.Database.EF.Repositories;

public class EFUserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public EFUserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task ConfirmEmail(string code, string userId)
    {
        var user = await _context.Users.FindAsync(userId);

        if (user is null)
        {
            // FIX: Throw an exception.
            return;
        }

        user.EmailStatus = EmailConfirmationStatus.VERIFIED;

        await _context.SaveChangesAsync();
    }

    public async Task<UserEntity?> FindByEmail(string email)
      => await _context.Users
                       .AsNoTrackingWithIdentityResolution()
                       .Where(x => x.Email == email)
                       .FirstOrDefaultAsync();

    public async Task<UserEntity?> FindById(string id)
      => await _context.Users
                       .AsNoTrackingWithIdentityResolution()
                       .Where(x => x.Id == id)
                       .FirstOrDefaultAsync();

    public async Task<UserEntity> Save(UserEntity user)
    {
        var efUser = new EFUserEntity(user);

        Console.WriteLine(JsonConvert.SerializeObject(efUser));

        // if (efUser.Address is not null)
        // {
        //     _context.UserAddress.Add(efUser.Address);
        // }

        _context.Users.Add(efUser);

        await _context.SaveChangesAsync();

        return efUser;
    }
}

using LivrariaOnline.Backend.Application.App.Users.Data;
using LivrariaOnline.Backend.Application.App.Users.Entities;
using LivrariaOnline.Backend.Infra.Database.EF.Contexts;
using Microsoft.EntityFrameworkCore;

namespace LivrariaOnline.Backend.Infra.Database.EF.Repositories;

public class EFEmailConfirmationRepository : IUserConfirmationRepository
{
    private readonly ApplicationDbContext _context;

    public EFEmailConfirmationRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task ConfirmCode(string code, string userId)
    {
        var confirmation = await GetByCode(code, userId);

        if (confirmation is null)
        {
            // FIX: Throw error
            return;
        }

        confirmation.Confirmed = true;
        confirmation.ConfirmedAt = DateTime.UtcNow;
    }

    public async Task<EmailConfirmationEntity?> GetByCode(string code, string userId)
    => await _context.UserEmailConfirmation
                     .AsNoTrackingWithIdentityResolution()
                     .Where(x => x.Code == code)
                     .Where(x => x.UserId == userId)
                     .Where(x => !x.Expired && !x.Confirmed)
                     .Where(x => DateTime.UtcNow < x.ValidTill)
                     .FirstOrDefaultAsync();

    public async Task<EmailConfirmationEntity> Save(EmailConfirmationEntity user)
    {
        _context.UserEmailConfirmation.Add(new(user));

        await _context.SaveChangesAsync();

        return user;
    }
}

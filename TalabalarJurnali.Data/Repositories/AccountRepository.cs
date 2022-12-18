using Microsoft.EntityFrameworkCore;
using TalabalarJurnali.Data.Data;
using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Data.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly AppDbContext _context;

    public AccountRepository(
        AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<AppUser>> GetAllAdminUsers()
    {
        throw new NotImplementedException();
    }

    public Task<List<AppUser>> GetAllStudentUsers()
    {
        throw new NotImplementedException();
    }

    public Task<List<AppUser>> GetAllTeacherUsers()
    {
        throw new NotImplementedException();
    }

    public async Task<AppUser> GetUserByEmail(string email)
    {
        var user = await _context.Users.FirstOrDefaultAsync(user => user.Email == email);

        return user;
    }

    public async Task<AppUser?> GetUserByUserName(string username)
    {
        var user = await _context.Users.FirstOrDefaultAsync(user => user.UserName == username);

        return user;
    }

    public async Task<AppUser> UpdateUset(AppUser user)
    {
        var updatedUser = _context.Users.Update(user);

        await _context.SaveChangesAsync();

        return updatedUser.Entity;
    }
}

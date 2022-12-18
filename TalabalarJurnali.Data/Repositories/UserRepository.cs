using Microsoft.EntityFrameworkCore;
using TalabalarJurnali.Data.Data;
using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Data.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(
        AppDbContext context)
    {
        _context = context;
    }

    public async Task<AppUser> CreateUserAsync(AppUser user)
    {
        var createdUser = await _context.Users.AddAsync(user);

        await _context.SaveChangesAsync();

        return createdUser.Entity;
    }

    public async Task DeleteUserAsync(AppUser user)
    {
        _context.Users.Remove(user);

        await _context.SaveChangesAsync();
    }

    public async Task<List<AppUser>> GetAllUserByRoleIdAsync(string role)
    {
        var user = _context.Users.Where(user => user.UserRole.ToString() == role).ToList();

        return user;
    }

    public Task<List<AppUser>> GetAllUsers()
    {
        var user = _context.Users.ToListAsync();

        return user;
    }

    public async Task<AppUser> GetUserByEmailAsync(string email)
    {
        var user = await _context.Users.FirstOrDefaultAsync(user => user.Email == email);

        return user;
    }

    public async Task<AppUser?> GetUserByIdAsync(Guid userId)
    {
        var user = await _context.Users.FirstOrDefaultAsync(user => user.Id == userId);

        return user;
    }

    public async Task<AppUser> GetUserByUserNameAsync(string username)
    {
        var user = await _context.Users.FirstOrDefaultAsync(user => user.UserName == username);

        return user;
    }

    public async Task<AppUser> UpdateUsetAsync(AppUser user)
    {
        var updatedUser = _context.Users.Update(user);

        await _context.SaveChangesAsync();

        return updatedUser.Entity;
    }
}

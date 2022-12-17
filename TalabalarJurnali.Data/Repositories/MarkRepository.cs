using Microsoft.EntityFrameworkCore;
using TalabalarJurnali.Data.Data;
using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Data.Repositories;

public class MarkRepository : IMarkRepository
{
    private readonly AppDbContext _context;
    public MarkRepository(
        AppDbContext context)
    {
        _context = context;
    }

    public async Task<Mark> CreateMarkAsync(Mark markEntity)
    {
        var entry = await _context.AddAsync(markEntity);

        await _context.SaveChangesAsync();

        return entry.Entity;
    }

    public async Task<Mark> EditMarkAsync(Mark markEntity)
    {
        var entry = await _context.AddAsync(markEntity);

        await _context.SaveChangesAsync();

        return entry.Entity;
    }

    public async Task<Mark?> GetMarkByIdAsync(Guid markId)
    {
        var entity = await _context.Marks.FindAsync(markId);

        return entity;
    }

    public async Task<List<Mark>?> GetMarksByUserIdAsync(Guid userId)
    {
        var marks = await _context.Marks.ToListAsync();

        var usersMark = marks.Where(mark => mark.UserId == userId).ToList();

        return usersMark;
    }

    public async Task RemoveMarkAsync(Guid markId)
    {
        _context.Remove(markId);

        await _context.SaveChangesAsync();
    }
}

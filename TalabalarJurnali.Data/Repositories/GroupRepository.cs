using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TalabalarJurnali.Data.Data;
using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Data.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        private readonly AppDbContext _context;

        public GroupRepository(
            AppDbContext context)
        {
            _context = context;
        }

        public async Task<Group> CreateGroupAsync(Group group)
        {
            var entry = await _context.Groups.AddAsync(group);

            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public async Task<Group> GetGroupByIdAsync(Guid groupId)
            => await _context.Groups.FirstOrDefaultAsync(g => g.Id == groupId);

        public async Task<Group> UpdateGroupAsync(Group group)
        {
            var entry =  _context.Groups.Update(group);

            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public async Task DeleteGroupAsync(Group group)
        {
             _context.Groups.Remove(group);

            await _context.SaveChangesAsync();
        }

        public async Task<List<Group>> GetAllGroups()
        {
            var entities = await _context.Groups.ToListAsync();

            return entities;
        }
    }
}

using TalabalarJurnali.Data.Entities;
using TalabalarJurnali.Data.Repositories;

namespace TalabalarJurnali.Data.Repositories
{
    public interface IGroupRepository
    {
        Task<List<Group>> GetAllGroups();
        Task<Group> CreateGroupAsync(Group group);
        Task<Group> GetGroupByIdAsync(Guid groupId);
        Task<Group> UpdateGroupAsync(Group group);
        Task DeleteGroupAsync(Group group);
    }
}

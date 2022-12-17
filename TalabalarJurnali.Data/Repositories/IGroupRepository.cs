using TalabalarJurnali.Data.Entities;
using TalabalarJurnali.Data.Repositories;

namespace TalabalarJurnali.Data.Repositories
{
    public interface IGroupRepository
    {
        #region GroupCRUD
            
        Task<Group> CreateGroupAsync(Group group);
        Task<Group> GetGroupByIdAsync(Group group);
        Task<Group> UpdateGroupAsync(Group group);
        Task DeleteGroupAsync(Group group);

        #endregion
    }
}

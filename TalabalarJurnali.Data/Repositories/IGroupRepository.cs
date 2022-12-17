using TalabalarJurnali.Data.Entities;

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

        #region Group users CRD

        Task<AppUser> AddUserToGroupAsync(Group group, AppUser user);
        Task<List<AppUser>> GetGroupUsersAsync(Group group);
        Task RemoveUserFromGroupAsync(Guid groupId, AppUser user);

        #endregion
    }
}

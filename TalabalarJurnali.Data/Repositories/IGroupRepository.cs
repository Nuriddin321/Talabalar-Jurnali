using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Data.Repositories
{
    public interface IGroupRepository
    {
        #region GroupCRUD


        Task<Group> CreateGroupAsync(string groupName);
        Task<Group> GetGroupByIdAsync(Guid groupId);
        Task<Group> UpdateGroupAsync(Guid groupId, string groupName);
        Task DeleteGroupAsync(Guid groupId);

        #endregion

        #region TeacherCRD

        Task<AppUser> AddTeacherToGroupAsync(Guid groupId, AppUser user);
        Task<List<AppUser>> GetGroupTeachersAsync(Guid groupId);
        Task RemoveTeacherFromGroupAsync(Guid groupId, AppUser user);

        #endregion

        #region StudentsCRD

         Task<AppUser> AddStudentToGroupAsync(Guid groupId, AppUser user);
         Task<List<AppUser>> GetGroupStudentsAsync(Guid groupId);
         Task RemoveStudentFromGroupAsync(Guid groupId, AppUser user);

        #endregion
            
    }
}

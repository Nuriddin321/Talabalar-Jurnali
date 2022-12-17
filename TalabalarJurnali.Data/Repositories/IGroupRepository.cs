using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Data.Repositories
{
    public interface IGroupRepository
    {
        #region GroupCRUD

        public Task CreateGroup(string groupName);
        public Task<Group> GetGroupById(Guid groupId);
        public Task UpdateGroup(Guid groupId, string groupName);
        public Task DeleteGroup(Guid groupId);

        #endregion

        #region TeacherCRD

        public Task AddTeacherToGroup(Guid groupId, AppUser user);
        public Task<List<AppUser>> GetGroupTeachers(Guid groupId);
        public Task RemoveTeacherFromGroup(Guid groupId, AppUser user);

        #endregion

        #region StudentsCRD

        public Task AddStudentToGroup(Guid groupId, AppUser user);
        public Task<List<AppUser>> GetGroupStudents(Guid groupId);
        public Task RemoveStudentFromGroup(Guid groupId, AppUser user);

        #endregion
            
    }
}

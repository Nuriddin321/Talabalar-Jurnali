using TalabalarJurnali.Admin.API.Dtos;

namespace TalabalarJurnali.Admin.API.Services
{
    public interface IGroupService
    {
        Task<GroupDto> CreateGroup(string groupName);
        Task<GroupDto> GetGroupByIdAsync(string groupId);
        Task<GroupDto> UpdateGroup(GroupDto group);
        Task<GroupDto> DeleteGroup(string groupId);
    }
}

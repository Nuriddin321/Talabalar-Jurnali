using TalabalarJurnali.Admin.API.Dtos;

namespace TalabalarJurnali.Admin.API.Services;

public interface IGroupService
{
    Task<List<GroupDto>> GetAllGroupsAsync();
    Task<GroupDto> GetGroupByIdAsync(Guid id);
    Task<GroupDto> CreateGroupAsync(CreateGroupDto createGroupDto);
    Task<GroupDto> UpdateGroupAsync(Guid id, UpdateGroupDto updateGroupDto);
    Task<bool> DeleteGropAsync(Guid id);
    Task<GroupDto> JoinGroupAsync(Guid userId, Guid groupId);
}

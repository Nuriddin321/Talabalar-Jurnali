using Mapster;
using System.Linq.Expressions;
using TalabalarJurnali.Admin.API.Dtos;
using TalabalarJurnali.Data.Entities;
using TalabalarJurnali.Data.Repositories;

namespace TalabalarJurnali.Admin.API.Services;

public class GroupService : IGroupService
{
    private readonly IGroupRepository _groupRepository;
    private readonly IUserRepository _accountRepository;

    public GroupService(
        IGroupRepository groupRepository,
        IUserRepository accountRepository)
    {
        _groupRepository = groupRepository;
        _accountRepository = accountRepository;
    }

    public async Task<GroupDto> CreateGroupAsync(CreateGroupDto createGroupDto)
    {
        if (string.IsNullOrWhiteSpace(createGroupDto.Name))
            return null;

        var group = new Group()
        {
            Name = createGroupDto.Name,
            Status = EGroupStatus.Active,
            StartDate = createGroupDto.StatDate,
            EndDate = createGroupDto.EndDate,
        };

        var groupResult = await _groupRepository.CreateGroupAsync(group);
        if(groupResult is null)
            return null;

        return group.Adapt<GroupDto>();
    }

    public async Task<bool> DeleteGropAsync(Guid id)
    {
        var group = await _groupRepository.GetGroupByIdAsync(id);
        if(group is null)
            return false;

        await _groupRepository.DeleteGroupAsync(group);
        return true;
    }

    public async Task<List<GroupDto>> GetAllGroupsAsync()
    {
        var groups = await _groupRepository.GetAllGroups();

        return groups.Select(group => group.Adapt<GroupDto>()).ToList();
    }

    public async Task<GroupDto> GetGroupByIdAsync(Guid id)
    {
        var group = await _groupRepository.GetGroupByIdAsync(id);
        if(group is null)
            return null;

        return group.Adapt<GroupDto>();
    }

    public async Task<GroupDto> JoinGroupAsync(JoinDto joinDto)
    {
        var group = await _groupRepository.GetGroupByIdAsync(joinDto.GeroupId);
        if (group is null)
            return null;

        var user =  await _accountRepository.GetUserByIdAsync(joinDto.UserId);
        if (group is null)
            return null;

        group.Users.Add(user);

        return group.Adapt<GroupDto>();
    }

    public async Task<GroupDto> UpdateGroupAsync(Guid id, UpdateGroupDto updateGroupDto)
    {
        var group = await _groupRepository.GetGroupByIdAsync(id);
        if(group is null)
            return null;

        group.Name = updateGroupDto.Name;
        group.StartDate = updateGroupDto.StatDate;
        group.EndDate = updateGroupDto.EndDate;
        group.Status = updateGroupDto.Status;

        return group.Adapt<GroupDto>();
    }
}

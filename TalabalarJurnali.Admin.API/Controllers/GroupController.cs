﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TalabalarJurnali.Admin.API.Dtos;
using TalabalarJurnali.Admin.API.Services;

namespace TalabalarJurnali.Admin.API.Controllers;
[Route("api/[controller]")]
[ApiController]
[Authorize]
public class GroupController : ControllerBase
{
    private readonly IGroupService _groupService;

    public GroupController(IGroupService groupService)
    {
        _groupService = groupService;
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<GroupDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll()
    {
        var groups = await _groupService.GetAllGroupsAsync();

        return Ok(groups);
    }

    [HttpGet("groupId")]
    [ProducesResponseType(typeof(GroupDto), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetById(Guid groupId)
    {
        var group = await _groupService.GetGroupByIdAsync(groupId);
        if (group is null)
            return BadRequest();

        return Ok(group);
    }

    [HttpPost("create")]
    [ProducesResponseType(typeof(GroupDto), StatusCodes.Status200OK)]
    public async Task<IActionResult> Create([FromBody] CreateGroupDto createGroupDto)
    {
        var createdGroup = await _groupService.CreateGroupAsync(createGroupDto);
        if (createdGroup is null)
            return BadRequest();

        return Ok(createdGroup);
    }

    [HttpPut("update/groupId")]
    [ProducesResponseType(typeof(GroupDto), StatusCodes.Status200OK)]
    public async Task<IActionResult> Update(Guid groupId, [FromBody] UpdateGroupDto UpdateGroupDto)
    {
        var updatedGroup = await _groupService.UpdateGroupAsync(groupId, UpdateGroupDto);
        if (updatedGroup is null)
            return BadRequest();

        return Ok(updatedGroup);
    }

    [HttpDelete("delete/groupId")]
    [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
    public async Task<IActionResult> Delete(Guid groupId)
    {
        var deletedGroup = await _groupService.DeleteGropAsync(groupId);
        if (deletedGroup is false)
            return BadRequest();

        return Ok();
    }

    [HttpPut("join")]
    [ProducesResponseType(typeof(GroupDto), StatusCodes.Status200OK)]
    public async Task<IActionResult> JoinGroup([FromBody] JoinDto joinDto)
    {
        var group = await _groupService.JoinGroupAsync(joinDto);
        if (group is null)
            return BadRequest();

        return Ok(group);
    }
}
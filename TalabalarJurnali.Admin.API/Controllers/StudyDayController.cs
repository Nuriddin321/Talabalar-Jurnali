// using Microsoft.AspNetCore.Mvc;
// using TalabalarJurnali.Admin.API.Dtos;

// namespace TalabalarJurnali.Admin.API.Controllers;
// [Route("api/[controller]")]
// [ApiController]
// public class StudyDayController : ControllerBase
// {
//     public StudyDayController()
//     {
//     }

//     [HttpGet("StudyDay")]
//     [ProducesResponseType(typeof(List<GroupDto>), StatusCodes.Status200OK)]
//     public async Task<IActionResult> GetAll()
//     {
//         var groups = await _groupService.GetAllGroupsAsync();

//         return Ok(groups);
//     }

//     [HttpGet("groupId:Guid")]
//     [ProducesResponseType(typeof(GroupDto), StatusCodes.Status200OK)]
//     public async Task<IActionResult> GetById(Guid groupId)
//     {
//         var group = await _groupService.GetGroupByIdAsync(groupId);
//         if (group is null)
//             return BadRequest();

//         return Ok(group);
//     }

//     [HttpPost("create")]
//     [ProducesResponseType(typeof(GroupDto), StatusCodes.Status200OK)]
//     public async Task<IActionResult> Create([FromForm] CreateGroupDto createGroupDto)
//     {
//         var createdGroup = await _groupService.CreateGroupAsync(createGroupDto);
//         if (createdGroup is null)
//             return BadRequest();

//         return Ok(createdGroup);
//     }

//     [HttpPut("update/groupId")]
//     [ProducesResponseType(typeof(GroupDto), StatusCodes.Status200OK)]
//     public async Task<IActionResult> Update(Guid groupId, [FromForm] UpdateGroupDto UpdateGroupDto)
//     {
//         var updatedGroup = await _groupService.UpdateGroupAsync(groupId, UpdateGroupDto);
//         if (updatedGroup is null)
//             return BadRequest();

//         return Ok(updatedGroup);
//     }

//     [HttpGet("groupId:Guid")]
//     [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
//     public async Task<IActionResult> Delete(Guid groupId)
//     {
//         var deletedGroup = await _groupService.DeleteGropAsync(groupId);
//         if (deletedGroup is false)
//             return BadRequest();

//         return Ok();
//     }

//     [HttpDelete("groupId:Guid, userId:Guid")]
//     [ProducesResponseType(typeof(GroupDto), StatusCodes.Status200OK)]
//     public async Task<IActionResult> JoinGroup(Guid groupId, Guid userId)
//     {
//         var group = await _groupService.JoinGroupAsync(groupId, userId);
//         if (group is null)
//             return BadRequest();

//         return Ok(group);
//     }
// }

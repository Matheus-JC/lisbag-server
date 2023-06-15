using LisbagServer.Application.DTOs;
using LisbagServer.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.V1;

[ApiController]
[Route(Routes.Base)]
[ApiVersion("1.0")]

public class UserProfileController : ControllerBase
{
    private readonly IUserProfileService _userProfileService;

    public UserProfileController(IUserProfileService userProfileService)
    {
        _userProfileService = userProfileService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var userProfiles = _userProfileService.GetAll();

        if (userProfiles is null)
        {
            return NotFound("User profiles not found");
        }

        return Ok(userProfiles);
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var userProfile = _userProfileService.Get(id);

        if (userProfile is null)
        {
            return NotFound("User profile not found");
        }

        return Ok(userProfile);
    }

    [HttpPost]
    public IActionResult Create([FromBody] UserProfileDTO userProfileDTO)
    {
        _userProfileService.Create(userProfileDTO);

        return new CreatedAtRouteResult(
            "Get",
            new { id = userProfileDTO.Id },
            userProfileDTO
        );
    }

    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, [FromBody] UserProfileDTO userProfileDTO)
    {
        if (id != userProfileDTO.Id || userProfileDTO is null)
        {
            return BadRequest();
        }

        _userProfileService.Update(userProfileDTO);

        return Ok(userProfileDTO);
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult Delete(int id)
    {
        var userProfile = _userProfileService.Get(id);

        if (userProfile is null)
        {
            return NotFound("User profile not found");
        }

        _userProfileService.Delete(id);

        return Ok(userProfile);
    }
}
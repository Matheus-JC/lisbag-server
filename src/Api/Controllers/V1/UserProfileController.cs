using LisbagServer.Application.DTOs;
using LisbagServer.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.V1;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]

public class UserProfileController : ControllerBase
{
    private readonly IUserProfileService _userProfileService;

    public UserProfileController(IUserProfileService userProfileService)
    {
        _userProfileService = userProfileService;
    }

    [HttpGet]
    public IActionResult Get(int id){
        var userProfile = _userProfileService.Get(id);

        if(userProfile == null){
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
}
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.V2;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("2.0")]

public class UserProfileController : ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok("Working Version 2.0");
    }
}
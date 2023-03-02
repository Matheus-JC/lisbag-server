using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.V2;

[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
public class ContentController : ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok("Working Version 2.0");
    }
}
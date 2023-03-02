using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.V1;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
public class ContentController : ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok("Working Version 1.0");
    }
}
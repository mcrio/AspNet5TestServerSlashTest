using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("/api")]
    public class MyController : ControllerBase
    {
        [HttpGet("{itemId}")]
        public IActionResult Get(string itemId)
        {
            return Ok(itemId);
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace BuggyApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class APIController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetData()
        {
            return Ok(new { message = "Data fetched successfully" });
        }
    }
}

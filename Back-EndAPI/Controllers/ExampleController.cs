using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace Back_EndAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController : ControllerBase
    {
        [HttpGet("items")]
        public IActionResult Get()
        {
            Example example = new Example
            {
                Id = 1,
                Name = "Sample Item"
            };
            return Ok(example);
        }
    }
}

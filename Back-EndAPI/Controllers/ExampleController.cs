using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace Back_EndAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController : ControllerBase
    {
        private static readonly List<Example> items = new List<Example>();
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

        [HttpGet("items")]
        public IActionResult GetAll()
        {
            List<Example> examples = new List<Example>
            {
                new Example { Id = 1, Name = "Sample Item 1" },
                new Example { Id = 2, Name = "Sample Item 2" }
            };
            return Ok(examples);
        }
        [HttpPost]
        public IActionResult Create([FromBody] Example newItem)
        {
            if (newItem == null)
            {
                return BadRequest();
            }
            
            newItem.Id = items.Count + 1;
            items.Add(newItem);
            return CreatedAtAction(nameof(Get), new { id = newItem.Id }, newItem);
        }
    }
}

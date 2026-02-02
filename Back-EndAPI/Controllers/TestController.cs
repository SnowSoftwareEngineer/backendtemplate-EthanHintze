using microsoft.AspNetCore.Mvc;
using Back_EndAPI.Services;

namespace Back_EndAPI.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestController : ControllerBase
    {
        private readonly TestService _testService;

        public TestController(TestService testService)
        {
            _testService = testService;
        }

        [HttpGet]
        public async Task<ActionResult<list<TestDTO>>> GetAllTests()
        {
            var tests = await _testService.GetAllTestsAsync();
            return Ok(tests);
        }
    }
}
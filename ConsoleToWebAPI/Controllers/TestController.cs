using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    public class TestController : ControllerBase
    {
        public string Get()
        {
            return "Hello from TestController GetRequest";
        }

        public string Get1()
        {
            return "GetRequest1";
        }
    }
}

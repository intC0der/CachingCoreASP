using Microsoft.AspNetCore.Mvc;

namespace WebApplication15.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {

        [HttpGet(Name = "GetInteger")]
        public int Get() 
        {
            var result = CacheModel.Get("test");

            return result;

        }
    }
}

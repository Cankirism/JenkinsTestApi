using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JenkinsTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]

        public string Get()
        {
            return "hello";
        }

        [HttpPost]
        public IActionResult Save(string name, string surname)
        {


            return Ok(surname + name);
        }
         
    
    }


}

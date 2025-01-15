using Microsoft.AspNetCore.Mvc;

namespace ASPForSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {

        [HttpGet]
        public IActionResult Greeting()
        {
            var greeting = new
            {
                Welcome = "You",
                Date = DateTime.Now,
            };

            return Ok(Newtonsoft.Json.JsonConvert.SerializeObject(greeting));
        }

    }
}

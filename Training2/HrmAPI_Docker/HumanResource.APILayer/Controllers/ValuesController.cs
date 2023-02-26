using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HumanResource.APILayer.Controllers
{
    [Route("api/[controller]")] //This has to be specified in Program.cs (app.UseRouting())
    //This is important. It tells the compiler that this class will behave like a APIController
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            //This returns an Ok object to generate a Code 200 response (everything went smoothly)
            return Ok("This is working successfully");
        }

        [HttpGet]
        [Route("{name}")]
        public IActionResult Get(string name)
        {
            //This returns an Ok object to generate a Code 200 response (everything went smoothly)
            return Ok("Welcome" + new {Id = 1, Name = name, Age = 30, City = "Springfield"});
        }


    }
}

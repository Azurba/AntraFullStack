using Hrm.ApplicationCore.Contract.Service;
using Hrm.ApplicationCore.Model.Request;
using HRM.ApllicationCore.Model.Request;
using HRM.ApllicationCore.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HumanResource.APILayer.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServiceAsync UserServiceAsync;

        public UserController(IUserServiceAsync _UserServiceAsync)
        {
            UserServiceAsync = _UserServiceAsync;
        }
        
        //"Configuration" for a POST request
        [HttpPost]
        public async Task<IActionResult> Post(UserRequestModel model)
        {
            if (ModelState.IsValid)
            {
               await UserServiceAsync.AddUserAsync(model);
                return Ok(model);
            }
            return BadRequest(model);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        { 
         var result=  await UserServiceAsync.GetAllUsersAsync();
            return  Ok(result);
        }
    }
}

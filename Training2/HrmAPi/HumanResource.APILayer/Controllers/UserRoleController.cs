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
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRoleServiceAsync UserRoleServiceAsync;

        public UserRoleController(IUserRoleServiceAsync _UserRoleServiceAsync)
        {
            UserRoleServiceAsync = _UserRoleServiceAsync;
        }
        
        //"Configuration" for a POST request
        [HttpPost]
        public async Task<IActionResult> Post(UserRoleRequestModel model)
        {
            if (ModelState.IsValid)
            {
               await UserRoleServiceAsync.AddUserRoleAsync(model);
                return Ok(model);
            }
            return BadRequest(model);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        { 
         var result=  await UserRoleServiceAsync.GetAllUserRolesAsync();
            return  Ok(result);
        }
    }
}

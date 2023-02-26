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
    public class EmployeeRoleController : ControllerBase
    {
        private readonly IEmployeeRoleServiceAsync EmployeeRoleServiceAsync;

        public EmployeeRoleController(IEmployeeRoleServiceAsync _EmployeeRoleServiceAsync)
        {
            EmployeeRoleServiceAsync = _EmployeeRoleServiceAsync;
        }
        
        //"Configuration" for a POST request
        [HttpPost]
        public async Task<IActionResult> Post(EmployeeRoleRequestModel model)
        {
            if (ModelState.IsValid)
            {
               await EmployeeRoleServiceAsync.AddEmployeeRoleAsync(model);
                return Ok(model);
            }
            return BadRequest(model);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        { 
         var result=  await EmployeeRoleServiceAsync.GetAllEmployeeRolesAsync();
            return  Ok(result);
        }
    }
}

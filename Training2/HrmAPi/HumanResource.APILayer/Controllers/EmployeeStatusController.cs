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
    public class EmployeeStatusController : ControllerBase
    {
        private readonly IEmployeeStatusServiceAsync EmployeeStatusServiceAsync;

        public EmployeeStatusController(IEmployeeStatusServiceAsync _EmployeeStatusServiceAsync)
        {
            EmployeeStatusServiceAsync = _EmployeeStatusServiceAsync;
        }
        
        //"Configuration" for a POST request
        [HttpPost]
        public async Task<IActionResult> Post(EmployeeStatusRequestModel model)
        {
            if (ModelState.IsValid)
            {
               await EmployeeStatusServiceAsync.AddEmployeeStatusAsync(model);
                return Ok(model);
            }
            return BadRequest(model);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        { 
         var result=  await EmployeeStatusServiceAsync.GetAllEmployeeStatusAsync();
            return  Ok(result);
        }
    }
}

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
    public class EmployeeTypeController : ControllerBase
    {
        private readonly IEmployeeTypeServiceAsync EmployeeTypeServiceAsync;

        public EmployeeTypeController(IEmployeeTypeServiceAsync _EmployeeTypeServiceAsync)
        {
            EmployeeTypeServiceAsync = _EmployeeTypeServiceAsync;
        }
        
        //"Configuration" for a POST request
        [HttpPost]
        public async Task<IActionResult> Post(EmployeeTypeRequestModel model)
        {
            if (ModelState.IsValid)
            {
               await EmployeeTypeServiceAsync.AddEmployeeTypeAsync(model);
                return Ok(model);
            }
            return BadRequest(model);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        { 
         var result=  await EmployeeTypeServiceAsync.GetAllEmployeeTypesAsync();
            return  Ok(result);
        }
    }
}

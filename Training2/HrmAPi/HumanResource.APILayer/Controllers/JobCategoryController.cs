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
    public class JobCategoryController : ControllerBase
    {
        private readonly IJobCategoryServiceAsync JobCategoryServiceAsync;

        public JobCategoryController(IJobCategoryServiceAsync _JobCategoryServiceAsync)
        {
            JobCategoryServiceAsync = _JobCategoryServiceAsync;
        }
        
        //"Configuration" for a POST request
        [HttpPost]
        public async Task<IActionResult> Post(JobCategoryRequestModel model)
        {
            if (ModelState.IsValid)
            {
               await JobCategoryServiceAsync.AddJobCategoryAsync(model);
                return Ok(model);
            }
            return BadRequest(model);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        { 
         var result=  await JobCategoryServiceAsync.GetAllJobCategoriesAsync();
            return  Ok(result);
        }
    }
}

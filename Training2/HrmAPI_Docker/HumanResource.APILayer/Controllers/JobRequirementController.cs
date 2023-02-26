using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Contract.Service;
using Hrm.Infrastructure.Service;
using HRM.ApplicationCore.Contract.Service;
using HRM.ApplicationCore.Model.Request;
using HRM.Infrastructure.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HumanResource.APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobRequirementController : ControllerBase
    {
        private readonly IJobRequirementServiceAsync jobRequirementServiceAsync;
        public JobRequirementController(IJobRequirementServiceAsync _jobRequirementServiceAsync)
        {
            jobRequirementServiceAsync = _jobRequirementServiceAsync;
        }

        [HttpPost]
        public async Task<IActionResult> Post(JobRequirementRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await jobRequirementServiceAsync.AddJobRequirementAsync(model);
                return Ok(model);
            }
            return BadRequest(model);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await jobRequirementServiceAsync.GetAllJobRequirementsAsync();
            return Ok(result);
        }
    }
}

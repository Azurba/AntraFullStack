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
    public class InterviewStatusController : ControllerBase
    {
        private readonly IInterviewStatusServiceAsync InterviewStatusServiceAsync;

        public InterviewStatusController(IInterviewStatusServiceAsync _InterviewStatusServiceAsync)
        {
            InterviewStatusServiceAsync = _InterviewStatusServiceAsync;
        }
        
        //"Configuration" for a POST request
        [HttpPost]
        public async Task<IActionResult> Post(InterviewStatusRequestModel model)
        {
            if (ModelState.IsValid)
            {
               await InterviewStatusServiceAsync.AddInterviewStatusAsync(model);
                return Ok(model);
            }
            return BadRequest(model);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        { 
         var result=  await InterviewStatusServiceAsync.GetAllInterviewStatusAsync();
            return  Ok(result);
        }
    }
}

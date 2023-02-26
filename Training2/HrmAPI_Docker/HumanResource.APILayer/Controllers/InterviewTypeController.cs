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
    public class InterviewTypeController : ControllerBase
    {
        private readonly IInterviewTypeServiceAsync InterviewTypeServiceAsync;

        public InterviewTypeController(IInterviewTypeServiceAsync _InterviewTypeServiceAsync)
        {
            InterviewTypeServiceAsync = _InterviewTypeServiceAsync;
        }
        
        //"Configuration" for a POST request
        [HttpPost]
        public async Task<IActionResult> Post(InterviewTypeRequestModel model)
        {
            if (ModelState.IsValid)
            {
               await InterviewTypeServiceAsync.AddInterviewTypeAsync(model);
                return Ok(model);
            }
            return BadRequest(model);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        { 
         var result=  await InterviewTypeServiceAsync.GetAllInterviewTypesAsync();
            return  Ok(result);
        }
    }
}

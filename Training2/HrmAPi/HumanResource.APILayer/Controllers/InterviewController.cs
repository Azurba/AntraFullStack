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
    public class InterviewController : ControllerBase
    {
        private readonly IInterviewServiceAsync InterviewServiceAsync;

        public InterviewController(IInterviewServiceAsync _InterviewServiceAsync)
        {
            InterviewServiceAsync = _InterviewServiceAsync;
        }
        
        //"Configuration" for a POST request
        [HttpPost]
        public async Task<IActionResult> Post(InterviewRequestModel model)
        {
            if (ModelState.IsValid)
            {
               await InterviewServiceAsync.AddInterviewAsync(model);
                return Ok(model);
            }
            return BadRequest(model);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        { 
         var result=  await InterviewServiceAsync.GetAllInterviewsAsync();
            return  Ok(result);
        }
    }
}

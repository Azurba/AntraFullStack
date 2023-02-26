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
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackServiceAsync FeedbackServiceAsync;

        public FeedbackController(IFeedbackServiceAsync _FeedbackServiceAsync)
        {
            FeedbackServiceAsync = _FeedbackServiceAsync;
        }
        
        //"Configuration" for a POST request
        [HttpPost]
        public async Task<IActionResult> Post(FeedbackRequestModel model)
        {
            if (ModelState.IsValid)
            {
               await FeedbackServiceAsync.AddFeedbackAsync(model);
                return Ok(model);
            }
            return BadRequest(model);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        { 
         var result=  await FeedbackServiceAsync.GetAllFeedbacksAsync();
            return  Ok(result);
        }
    }
}

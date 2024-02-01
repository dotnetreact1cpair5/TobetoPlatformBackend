using Business.Abstract;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCompletionController : ControllerBase
    {
        ICourseCompletionService _courseCompletionService;
        public CourseCompletionController(ICourseCompletionService courseCompletionService)
        {
            _courseCompletionService = courseCompletionService;
        }


        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _courseCompletionService.GetListCourseCompletion();
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] int accountCourseCompletionId)
        {
            var result = await _courseCompletionService.GetById(accountCourseCompletionId);
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCourseCompletionRequest createCourseCompletionRequest)
        {
            var result = await _courseCompletionService.Add(createCourseCompletionRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCourseCompletionRequest updateCourseCompletionRequest)
        {
            var result = await _courseCompletionService.Update(updateCourseCompletionRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteCourseCompletionRequest deleteCourseCompletionRequest)
        {

            var result = await _courseCompletionService.Delete(deleteCourseCompletionRequest);
            return Ok(result);
        }

    }


}

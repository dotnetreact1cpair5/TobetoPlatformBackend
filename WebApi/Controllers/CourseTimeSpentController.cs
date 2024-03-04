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
    public class CourseTimeSpentController : ControllerBase
    {
        ICourseTimeSpentService _courseTimeSpentService;
        public CourseTimeSpentController(ICourseTimeSpentService courseTimeSpentService)
        {
            _courseTimeSpentService = courseTimeSpentService;
        }


        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _courseTimeSpentService.GetListCourseTimeSpent();
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] int courseTimeSpentId)
        {
            var result = await _courseTimeSpentService.GetById(courseTimeSpentId);
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCourseTimeSpentRequest createCourseTimeSpentRequest)
        {
            var result = await _courseTimeSpentService.Add(createCourseTimeSpentRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCourseTimeSpentRequest updateCourseTimeSpentRequest)
        {
            var result = await _courseTimeSpentService.Update(updateCourseTimeSpentRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteCourseTimeSpentRequest deleteCourseTimeSpentRequest)
        {

            var result = await _courseTimeSpentService.Delete(deleteCourseTimeSpentRequest);
            return Ok(result);
        }

    }


}

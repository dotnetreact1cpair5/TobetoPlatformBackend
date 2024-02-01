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
    public class CoursePageLessonController : ControllerBase
    {
        ICoursePageLessonService _coursePageLessonService;
        public CoursePageLessonController(ICoursePageLessonService coursePageLessonService)
        {
            _coursePageLessonService = coursePageLessonService;
        }


        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _coursePageLessonService.GetListCoursePageLesson();
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] int coursePageLessonId)
        {
            var result = await _coursePageLessonService.GetById(coursePageLessonId);
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCoursePageLessonRequest createCoursePageLessonRequest)
        {
            var result = await _coursePageLessonService.Add(createCoursePageLessonRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCoursePageLessonRequest updateCoursePageLessonRequest)
        {
            var result = await _coursePageLessonService.Update(updateCoursePageLessonRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteCoursePageLessonRequest deleteCoursePageLessonRequest)
        {

            var result = await _coursePageLessonService.Delete(deleteCoursePageLessonRequest);
            return Ok(result);
        }

    }
}

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
    public class CoursePageController : ControllerBase
    {
        ICoursePageService _coursePageService;
        public CoursePageController(ICoursePageService coursePageService)
        {
            _coursePageService = coursePageService;
        }


        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _coursePageService.GetListCoursePage();
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] int coursePageId)
        {
            var result = await _coursePageService.GetById(coursePageId);
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCoursePageRequest createCoursePageRequest)
        {
            var result = await _coursePageService.Add(createCoursePageRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCoursePageRequest updateCoursePageRequest)
        {
            var result = await _coursePageService.Update(updateCoursePageRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteCoursePageRequest deleteCoursePageRequest)
        {

            var result = await _coursePageService.Delete(deleteCoursePageRequest);
            return Ok(result);
        }

    }
}

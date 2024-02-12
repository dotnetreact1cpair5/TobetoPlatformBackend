using Business.Abstract;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _courseService.GetListCourse();
            return Ok(result);
        }

        [HttpGet("getbyaccountid")]
        public async Task<IActionResult> GetByAccountId([FromQuery] int accountId)
        {
            var result = await _courseService.GetByAccountId(accountId);
            return Ok(result);
        }

        [HttpGet("getbycourseid")]
        public async Task<IActionResult> GetByCourseId([FromQuery] int courseId)
        {
            var result = await _courseService.GetByCourseId(courseId);
            return Ok(result);
        }

        [HttpGet("getbyuserid")]
        public async Task<IActionResult> GetByUserId([FromQuery] int userId)
        {
            var result = await _courseService.GetByUserId(userId);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCourseRequest createCourseRequest)
        {
            var result = await _courseService.Add(createCourseRequest);
            return Ok(result);
        }


        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCourseRequest updateCourseRequest)
        {
            var result = await _courseService.Update(updateCourseRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteCourseRequest deleteCourseRequest)
        {

            var result = await _courseService.Delete(deleteCourseRequest);
            return Ok(result);
        }

    }
}

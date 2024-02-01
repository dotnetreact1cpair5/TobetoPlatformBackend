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
    public class CourseCoursePageController : ControllerBase
    {
        ICourseCoursePageService _courseCoursePageService;
        public CourseCoursePageController(ICourseCoursePageService courseCoursePageService)
        {
            _courseCoursePageService = courseCoursePageService;
        }


        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _courseCoursePageService.GetListCourseCoursePage();
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] int courseCoursePageId)
        {
            var result = await _courseCoursePageService.GetById(courseCoursePageId);
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCourseCoursePageRequest createCourseCoursePageRequest)
        {
            var result = await _courseCoursePageService.Add(createCourseCoursePageRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCourseCoursePageRequest updateCourseCoursePageRequest)
        {
            var result = await _courseCoursePageService.Update(updateCourseCoursePageRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteCourseCoursePageRequest deleteCourseCoursePageRequest)
        {

            var result = await _courseCoursePageService.Delete(deleteCourseCoursePageRequest);
            return Ok(result);
        }

    }

}

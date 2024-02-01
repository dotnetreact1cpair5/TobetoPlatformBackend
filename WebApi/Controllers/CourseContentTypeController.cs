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
    public class CourseContentTypeController : ControllerBase
    {
        IContentTypeService _courseContentTypeService;
        public CourseContentTypeController(IContentTypeService courseContentTypeService)
        {
            _courseContentTypeService = courseContentTypeService;
        }



        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _courseContentTypeService.GetListCourseContentType(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateContentTypeRequest createCourseContentTypeRequest)
        {
            var result = await _courseContentTypeService.Add(createCourseContentTypeRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateContentTypeRequest updateCourseContentTypeRequest)
        {
            var result = await _courseContentTypeService.Update(updateCourseContentTypeRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteContentTypeRequest deleteCourseContentTypeRequest)
        {

            var result = await _courseContentTypeService.Delete(deleteCourseContentTypeRequest);
            return Ok(result);
        }
    }
}

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
    public class CourseCategoryController : ControllerBase
    {
        ICourseCategoryService _courseCategoryService;
        public CourseCategoryController(ICourseCategoryService courseCategoryService)
        {
            _courseCategoryService = courseCategoryService;
        }



        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _courseCategoryService.GetListCourseCategory();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCategoryRequest createCourseCategoryRequest)
        {
            var result = await _courseCategoryService.Add(createCourseCategoryRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCategoryRequest updateCourseCategoryRequest)
        {
            var result = await _courseCategoryService.Update(updateCourseCategoryRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteCategoryRequest deleteCourseCategoryRequest)
        {

            var result = await _courseCategoryService.Delete(deleteCourseCategoryRequest);
            return Ok(result);
        }
    }
}

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
    public class CourseFavouriteController : ControllerBase
    {
        ICourseFavouriteService _courseFavouriteService;
        public CourseFavouriteController(ICourseFavouriteService courseFavouriteService)
        {
            _courseFavouriteService = courseFavouriteService;
        }


        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _courseFavouriteService.GetListCourseFavourite();
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] int courseFavouriteId)
        {
            var result = await _courseFavouriteService.GetById(courseFavouriteId);
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCourseFavouriteRequest createCourseFavouriteRequest)
        {
            var result = await _courseFavouriteService.Add(createCourseFavouriteRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCourseFavouriteRequest updateCourseFavouriteRequest)
        {
            var result = await _courseFavouriteService.Update(updateCourseFavouriteRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteCourseFavouriteRequest deleteCourseFavouriteRequest)
        {

            var result = await _courseFavouriteService.Delete(deleteCourseFavouriteRequest);
            return Ok(result);
        }

    }


}

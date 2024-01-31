using Business.Abstract;
using Business.Dtos.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonFavouriteController : ControllerBase
    {
        ILessonFavouriteService _lessonFavouriteService;
        public LessonFavouriteController(ILessonFavouriteService lessonFavouriteService)
        {
            _lessonFavouriteService = lessonFavouriteService;
        }


        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _lessonFavouriteService.GetListLessonFavourite();
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] int accountLessonFavouriteId)
        {
            var result = await _lessonFavouriteService.GetById(accountLessonFavouriteId);
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateLessonFavouriteRequest createLessonFavouriteRequest)
        {
            var result = await _lessonFavouriteService.Add(createLessonFavouriteRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateLessonFavouriteRequest updateLessonFavouriteRequest)
        {
            var result = await _lessonFavouriteService.Update(updateLessonFavouriteRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteLessonFavouriteRequest deleteLessonFavouriteRequest)
        {

            var result = await _lessonFavouriteService.Delete(deleteLessonFavouriteRequest);
            return Ok(result);
        }

    }


}

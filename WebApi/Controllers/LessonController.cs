using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        ILessonService _lessonService;
        public LessonController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }



        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _lessonService.GetListLesson();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateLessonRequest createLessonRequest)
        {
            var result = await _lessonService.Add(createLessonRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateLessonRequest updateLessonRequest)
        {
            var result = await _lessonService.Update(updateLessonRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteLessonRequest deleteLessonRequest)
        {

            var result = await _lessonService.Delete(deleteLessonRequest);
            return Ok(result);
        }

    }
}

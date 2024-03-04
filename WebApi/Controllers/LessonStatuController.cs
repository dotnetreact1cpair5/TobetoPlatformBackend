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
    public class LessonStatuController : ControllerBase
    {
        ILessonStatuService _lessonStatuService;
        public LessonStatuController(ILessonStatuService lessonStatuService)
        {
            _lessonStatuService = lessonStatuService;
        }



        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _lessonStatuService.GetListLesson(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateLessonStatuRequest createLessonStatuRequest)
        {
            var result = await _lessonStatuService.Add(createLessonStatuRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateLessonStatuRequest updateLessonStatuRequest)
        {
            var result = await _lessonStatuService.Update(updateLessonStatuRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteLessonStatuRequest deleteLessonStatuRequest)
        {

            var result = await _lessonStatuService.Delete(deleteLessonStatuRequest);
            return Ok(result);
        }
    }
}

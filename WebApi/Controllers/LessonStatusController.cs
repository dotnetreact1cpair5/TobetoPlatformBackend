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
    public class LessonStatusController : ControllerBase
    {
        ILessonStatusService _lessonStatusService;
        public LessonStatusController(ILessonStatusService lessonStatusService)
        {
            _lessonStatusService = lessonStatusService;
        }



        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _lessonStatusService.GetListLesson(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateLessonStatusRequest createLessonStatusRequest)
        {
            var result = await _lessonStatusService.Add(createLessonStatusRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateLessonStatusRequest updateLessonStatusRequest)
        {
            var result = await _lessonStatusService.Update(updateLessonStatusRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteLessonStatusRequest deleteLessonStatusRequest)
        {

            var result = await _lessonStatusService.Delete(deleteLessonStatusRequest);
            return Ok(result);
        }
    }
}

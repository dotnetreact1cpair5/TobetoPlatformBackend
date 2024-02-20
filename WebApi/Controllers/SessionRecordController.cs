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
    public class SessionRecordController : ControllerBase
    {
        ISessionRecordService _sessionRecordService;
        public SessionRecordController(ISessionRecordService sessionRecordService)
        {
            _sessionRecordService = sessionRecordService;
        }


        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _sessionRecordService.GetListSessionRecord();
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] int sessionRecordId)
        {
            var result = await _sessionRecordService.GetById(sessionRecordId);
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateSessionRecordRequest createSessionRecordRequest)
        {
            var result = await _sessionRecordService.Add(createSessionRecordRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateSessionRecordRequest updateSessionRecordRequest)
        {
            var result = await _sessionRecordService.Update(updateSessionRecordRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteSessionRecordRequest deleteSessionRecordRequest)
        {

            var result = await _sessionRecordService.Delete(deleteSessionRecordRequest);
            return Ok(result);
        }

    }


}

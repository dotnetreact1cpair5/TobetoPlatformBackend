using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationStatusController : ControllerBase
    {
        IEducationStatusService _educationStatusService;
        public EducationStatusController(IEducationStatusService educationStatusService)
        {
            _educationStatusService = educationStatusService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _educationStatusService.GetListEducationStatus(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateEducationStatusRequest createEducationStatusRequest)
        {
            var result = await _educationStatusService.Add(createEducationStatusRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateEducationStatusRequest updateEducationStatusRequest)
        {
            var result = await _educationStatusService.Update(updateEducationStatusRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteEducationStatusRequest deleteEducationStatusRequest)
        {
            var result = await _educationStatusService.Delete(deleteEducationStatusRequest);
            return Ok(result);
        }
    }
}

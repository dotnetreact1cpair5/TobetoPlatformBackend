using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationProgramsController : ControllerBase
    {
        IEducationProgramService _educationProgramService;
        public EducationProgramsController(IEducationProgramService educationProgramService)
        {
            _educationProgramService = educationProgramService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _educationProgramService.GetListEducationProgram(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateEducationProgramRequest createEducationProgramRequest)
        {
            var result = await _educationProgramService.Add(createEducationProgramRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateEducationProgramRequest updateEducationProgramRequest)
        {
            var result = await _educationProgramService.Update(updateEducationProgramRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteEducationProgramRequest deleteEducationProgramRequest)
        {
            var result = await _educationProgramService.Delete(deleteEducationProgramRequest);
            return Ok(result);
        }
    }
}

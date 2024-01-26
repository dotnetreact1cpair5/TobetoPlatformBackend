using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversitiesController : ControllerBase
    {
        IUniversityService _universityService;
        public UniversitiesController(IUniversityService universityService)
        {
            _universityService = universityService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _universityService.GetListUniversity(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateUniversityRequest createUniversityRequest)
        {
            var result = await _universityService.Add(createUniversityRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateUniversityRequest updateUniversityRequest)
        {
            var result = await _universityService.Update(updateUniversityRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteUniversityRequest deleteUniversityRequest)
        {
            var result = await _universityService.Delete(deleteUniversityRequest);
            return Ok(result);
        }
    }
}

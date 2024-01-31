using Business.Abstract;
using Business.Dtos.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentClassController : ControllerBase
    {
        IStudentClassService _studentClassService;
        public StudentClassController(IStudentClassService studentClassService)
        {
            _studentClassService = studentClassService;
        }



        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _studentClassService.GetListStudentClass();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateStudentClassRequest createStudentClassRequest)
        {
            var result = await _studentClassService.Add(createStudentClassRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateStudentClassRequest updateStudentClassRequest)
        {
            var result = await _studentClassService.Update(updateStudentClassRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteStudentClassRequest deleteStudentClassRequest)
        {

            var result = await _studentClassService.Delete(deleteStudentClassRequest);
            return Ok(result);
        }

    }
}

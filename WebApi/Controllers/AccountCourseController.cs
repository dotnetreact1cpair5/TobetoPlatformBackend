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
    public class AccountCourseController : ControllerBase
    {
        IAccountCourseService _accountCourseService;
        public AccountCourseController(IAccountCourseService accountCourseService)
        {
            _accountCourseService = accountCourseService;
        }


        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _accountCourseService.GetListAccountCourse();
            return Ok(result);
        }

        [HttpGet("getbyuserid")]
        public async Task<IActionResult> GetByUserId([FromQuery] int userId)
        {
            var result = await _accountCourseService.GetByUserId(userId);
            return Ok(result);
        }

        [HttpGet("getbycourseid")]
        public async Task<IActionResult> GetByCourseId([FromQuery] int courseId)
        {
            var result = await _accountCourseService.GetByCourseId(courseId);
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAccountCourseRequest createAccountCourseRequest )
        {
            var result = await _accountCourseService.Add(createAccountCourseRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateAccountCourseRequest updateAccountCourseRequest)
        {
            var result = await _accountCourseService.Update(updateAccountCourseRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteAccountCourseRequest  deleteAccountCourseRequest)
        {

            var result = await _accountCourseService.Delete(deleteAccountCourseRequest);
            return Ok(result);
        }

    }
}

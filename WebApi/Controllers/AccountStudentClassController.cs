using Business.Abstract;
using Business.Dtos.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountStudentClassController : ControllerBase
    {
        IAccountStudentClassService _accountStudentClassService;
        public AccountStudentClassController(IAccountStudentClassService accountStudentClassService)
        {
            _accountStudentClassService = accountStudentClassService;
        }


        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _accountStudentClassService.GetListAccountStudentClass();
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] int AccountStudentClassId)
        {
            var result = await _accountStudentClassService.GetById(AccountStudentClassId);
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAccountStudentClassRequest createAccountStudentClassRequest)
        {
            var result = await _accountStudentClassService.Add(createAccountStudentClassRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateAccountStudentClassRequest updateAccountStudentClassRequest)
        {
            var result = await _accountStudentClassService.Update(updateAccountStudentClassRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteAccountStudentClassRequest deleteAccountStudentClassRequest)
        {

            var result = await _accountStudentClassService.Delete(deleteAccountStudentClassRequest);
            return Ok(result);
        }

    }
}

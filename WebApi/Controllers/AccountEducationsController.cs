using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountEducationsController : ControllerBase
    {
        IAccountEducationService _accountEducationService;
        public AccountEducationsController(IAccountEducationService accountEducationService)
        {
            _accountEducationService = accountEducationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _accountEducationService.GetListAccountEducation(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAccountEducationRequest createAccountEducationRequest)
        {
            var result = await _accountEducationService.Add(createAccountEducationRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateAccountEducationRequest updateAccountEducationRequest)
        {
            var result = await _accountEducationService.Update(updateAccountEducationRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteAccountEducationRequest deleteAccountEducationRequest)
        {
            var result = await _accountEducationService.Delete(deleteAccountEducationRequest);
            return Ok(result);
        }
    }
}

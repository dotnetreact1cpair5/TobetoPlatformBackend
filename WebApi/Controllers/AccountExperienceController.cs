using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountExperienceController : ControllerBase
    {
        IAccountExperienceService _accountExperienceService;
        public AccountExperienceController(IAccountExperienceService accountExperienceService)
        {
            _accountExperienceService = accountExperienceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _accountExperienceService.GetListAccountExperience(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAccountExperienceRequest createAccountExperienceRequest)
        {
            var result = await _accountExperienceService.Add(createAccountExperienceRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateAccountExperienceRequest updateAccountExperienceRequest)
        {
            var result = await _accountExperienceService.Update(updateAccountExperienceRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteAccountExperienceRequest deleteAccountExperienceRequest)
        {
            var result = await _accountExperienceService.Delete(deleteAccountExperienceRequest);
            return Ok(result);
        }
    }
}

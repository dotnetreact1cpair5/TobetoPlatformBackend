using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountSocialMediasController : ControllerBase
    {
        IAccountSocialMediaService _accountSocialMediaService;
        public AccountSocialMediasController(IAccountSocialMediaService accountSocialMediaService)
        {
            _accountSocialMediaService = accountSocialMediaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _accountSocialMediaService.GetListAccountSocialMedia(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAccountSocialMediaRequest createAccountSocialMediaRequest)
        {
            var result = await _accountSocialMediaService.Add(createAccountSocialMediaRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateAccountSocialMediaRequest updateAccountSocialMediaRequest)
        {
            var result = await _accountSocialMediaService.Update(updateAccountSocialMediaRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteAccountSocialMediaRequest deleteAccountSocialMediaRequest)
        {
            var result = await _accountSocialMediaService.Delete(deleteAccountSocialMediaRequest);
            return Ok(result);
        }
    }
}

using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountForeignLanguageController : ControllerBase
    {
        IAccountForeignLanguageService _accountForeignLanguageService;

        public AccountForeignLanguageController(IAccountForeignLanguageService accountForeignLanguageService)
        {
            _accountForeignLanguageService = accountForeignLanguageService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _accountForeignLanguageService.GetListAccount(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAccountForeignLanguageRequest createAccountForeignLanguageRequest)
        {
            var result = await _accountForeignLanguageService.Add(createAccountForeignLanguageRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateAccountForeignLanguageRequest updateAccountForeignLanguageRequest)
        {
            var result = await _accountForeignLanguageService.Update(updateAccountForeignLanguageRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteAccountForeignLanguageRequest deleteAccountForeignLanguageRequest)
        {

            var result = await _accountForeignLanguageService.Delete(deleteAccountForeignLanguageRequest);
            return Ok(result);
        }

    }
}

using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountSkillController : ControllerBase
    {
        IAccountSkillService _accountSkillService;

        public AccountSkillController(IAccountSkillService accountSkillService)
        {
            _accountSkillService = accountSkillService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _accountSkillService.GetListAccountSkill(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAccountSkillRequest createAccountSkillRequest)
        {
            var result = await _accountSkillService.Add(createAccountSkillRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateAccountSkillRequest updateAccountSkillRequest)
        {
            var result = await _accountSkillService.Update(updateAccountSkillRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteAccountSkillRequest deleteAccountSkillRequest)
        {

            var result = await _accountSkillService.Delete(deleteAccountSkillRequest);
            return Ok(result);
        }
    }
}

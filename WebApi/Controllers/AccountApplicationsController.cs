using Business.Abstract;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountApplicationsController : ControllerBase
    {
        IAccountApplicationService _accountApplicationService;
        public AccountApplicationsController(IAccountApplicationService accountApplicationService)
        {
            _accountApplicationService = accountApplicationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _accountApplicationService.GetListAccountApplication(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAccountApplicationRequest createAccountApplicationRequest)
        {
            var result = await _accountApplicationService.Add(createAccountApplicationRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateAccountApplicationRequest updateAccountApplicationRequest)
        {
            var result = await _accountApplicationService.Update(updateAccountApplicationRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteAccountApplicationRequest deleteAccountApplicationRequest)
        {
            var result = await _accountApplicationService.Delete(deleteAccountApplicationRequest);
            return Ok(result);
        }
    }
}

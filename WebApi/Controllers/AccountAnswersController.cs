using Business.Abstract;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountAnswersController : ControllerBase
    {
        IAccountAnswerService _accountAnswerService;
        public AccountAnswersController(IAccountAnswerService accountAnswerService)
        {
            _accountAnswerService = accountAnswerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _accountAnswerService.GetList(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAccountAnswerRequest createAccountAnswerRequest)
        {
            var result = await _accountAnswerService.Add(createAccountAnswerRequest);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateAccountAnswerRequest updateAccountAnswerRequest)
        {
            var result = await _accountAnswerService.Update(updateAccountAnswerRequest);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteAccountAnswerRequest deleteAccountAnswerRequest)
        {

            var result = await _accountAnswerService.Delete(deleteAccountAnswerRequest);
            return Ok(result);
        }

    }
}

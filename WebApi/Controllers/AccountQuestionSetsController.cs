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
    public class AccountQuestionSetsController : ControllerBase
    {
        IAccountQuestionSetService _accountQuestionSetService;
        public AccountQuestionSetsController(IAccountQuestionSetService accountQuestionSetService)
        {
            _accountQuestionSetService = accountQuestionSetService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _accountQuestionSetService.GetList(pageRequest);
            return Ok(result);
        }

        //[HttpGet]
        //public async Task<IActionResult> GetById([FromQuery] PageRequest pageRequest)
        //{
        //    var result = await _accountAnswerService.GetListAccount(pageRequest);
        //    return Ok(result);
        //}

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAccountQuestionSetRequest createAccountQuestionSetRequest)
        {
            var result = await _accountQuestionSetService.Add(createAccountQuestionSetRequest);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateAccountQuestionSetRequest updateAccountQuestionSetRequest)
        {
            var result = await _accountQuestionSetService.Update(updateAccountQuestionSetRequest);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteAccountQuestionSetRequest deleteAccountQuestionSetRequest)
        {

            var result = await _accountQuestionSetService.Delete(deleteAccountQuestionSetRequest);
            return Ok(result);
        }
    }
}

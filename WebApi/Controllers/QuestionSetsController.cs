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
    public class QuestionSetsController : ControllerBase
    {
        IQuestionSetService _questionSetService;
        public QuestionSetsController(IQuestionSetService questionSetService)
        {
            _questionSetService = questionSetService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _questionSetService.GetList(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateQuestionSetRequest createQuestionSetRequest)
        {
            var result = await _questionSetService.Add(createQuestionSetRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateQuestionSetRequest updateQuestionSetRequest)
        {
            var result = await _questionSetService.Update(updateQuestionSetRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteQuestionSetRequest deleteQuestionSetRequest)
        {

            var result = await _questionSetService.Delete(deleteQuestionSetRequest);
            return Ok(result);
        }
    }
}

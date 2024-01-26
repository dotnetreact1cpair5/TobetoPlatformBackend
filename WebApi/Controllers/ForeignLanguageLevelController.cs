using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForeignLanguageLevelController : ControllerBase
    {
        IForeignLanguageLevelService _foreignLanguageLevelService;
        

        public ForeignLanguageLevelController(IForeignLanguageLevelService foreignLanguageLevelService)
        {
            _foreignLanguageLevelService = foreignLanguageLevelService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _foreignLanguageLevelService.GetListForeignLanguageLevel(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateForeignLanguageLevelRequest createForeignLanguageLevelRequest)
        {
            var result = await _foreignLanguageLevelService.Add(createForeignLanguageLevelRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateForeignLanguageLevelRequest updateForeignLanguageLevelRequest)
        {
            var result = await _foreignLanguageLevelService.Update(updateForeignLanguageLevelRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteForeignLanguageLevelRequest deleteForeignLanguageLevelRequest)
        {

            var result = await _foreignLanguageLevelService.Delete(deleteForeignLanguageLevelRequest);
            return Ok(result);
        }

    }
}

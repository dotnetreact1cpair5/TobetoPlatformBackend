using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForeignLanguageController : ControllerBase
    {
        IForeignLanguageService _foreignLanguageService;

        public ForeignLanguageController(IForeignLanguageService foreignLanguageService)
        {
            _foreignLanguageService = foreignLanguageService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _foreignLanguageService.GetListForeignLanguage(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateForeignLanguageRequest createForeignLanguageRequest)
        {
            var result = await _foreignLanguageService.Add(createForeignLanguageRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateForeignLanguageRequest updateForeignLanguageRequest)
        {
            var result = await _foreignLanguageService.Update(updateForeignLanguageRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteForeignLanguageRequest deleteForeignLanguageRequest)
        {

            var result = await _foreignLanguageService.Delete(deleteForeignLanguageRequest);
            return Ok(result);
        }

    }
}

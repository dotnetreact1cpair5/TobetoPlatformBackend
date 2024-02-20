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
    public class ContentController : ControllerBase
    {
        IContentService _contentService;
        public ContentController(IContentService contentService)
        {
            _contentService = contentService;
        }



        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _contentService.GetListContent();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateContentRequest createContentRequest)
        {
            var result = await _contentService.Add(createContentRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateContentRequest updateContentRequest)
        {
            var result = await _contentService.Update(updateContentRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteContentRequest deleteContentRequest)
        {

            var result = await _contentService.Delete(deleteContentRequest);
            return Ok(result);
        }

    }
}

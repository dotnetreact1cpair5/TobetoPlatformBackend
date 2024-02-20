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
    public class ContentTypeController : ControllerBase
    {
        IContentTypeService _contentTypeService;
        public ContentTypeController(IContentTypeService contentTypeService)
        {
            _contentTypeService = contentTypeService;
        }



        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _contentTypeService.GetListContentType(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateContentTypeRequest createContentTypeRequest)
        {
            var result = await _contentTypeService.Add(createContentTypeRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateContentTypeRequest updateContentTypeRequest)
        {
            var result = await _contentTypeService.Update(updateContentTypeRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteContentTypeRequest deleteContentTypeRequest)
        {

            var result = await _contentTypeService.Delete(deleteContentTypeRequest);
            return Ok(result);
        }
    }
}

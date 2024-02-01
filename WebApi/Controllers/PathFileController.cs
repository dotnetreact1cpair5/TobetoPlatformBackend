using Business.Abstract;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PathFileController : ControllerBase
    {
        IPathFileService _pathService;

        public PathFileController(IPathFileService pathFileService)
        {
            _pathService = pathFileService;
        }

        [HttpPost("add")]

        public async Task<IActionResult> Add([FromForm] CreatePathFileRequest createPathFileRequest)
        {

            var result = await _pathService.Add(createPathFileRequest);

            return Ok(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromForm] UpdatePathFileRequest updatePathFileRequest)
        {

            var result = await _pathService.Update(updatePathFileRequest);

            return Ok(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromForm] DeletePathFileRequest deletePathFileRequest)
        {

            var result = await _pathService.Delete(deletePathFileRequest);

            return Ok(result);
        }

    }
}

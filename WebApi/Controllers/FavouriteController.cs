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
    public class FavouriteController : ControllerBase
    {
        IFavouriteService _favouriteService;
        public FavouriteController(IFavouriteService favouriteService)
        {
            _favouriteService = favouriteService;
        }


        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _favouriteService.GetListFavourite();
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] int favouriteId)
        {
            var result = await _favouriteService.GetById(favouriteId);
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateFavouriteRequest createFavouriteRequest)
        {
            var result = await _favouriteService.Add(createFavouriteRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateFavouriteRequest updateFavouriteRequest)
        {
            var result = await _favouriteService.Update(updateFavouriteRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteFavouriteRequest deleteFavouriteRequest)
        {

            var result = await _favouriteService.Delete(deleteFavouriteRequest);
            return Ok(result);
        }

    }


}

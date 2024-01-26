using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaPlatformsController : ControllerBase
    {
        ISocialMediaPlatformService _socialMediaPlatformService;
        public SocialMediaPlatformsController(ISocialMediaPlatformService socialMediaPlatformService)
        {
            _socialMediaPlatformService = socialMediaPlatformService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _socialMediaPlatformService.GetListSocialMediaPlatform(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateSocialMediaPlatformRequest createSocialMediaPlatformRequest)
        {
            var result = await _socialMediaPlatformService.Add(createSocialMediaPlatformRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateSocialMediaPlatformRequest updateSocialMediaPlatformRequest)
        {
            var result = await _socialMediaPlatformService.Update(updateSocialMediaPlatformRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteSocialMediaPlatformRequest deleteSocialMediaPlatformRequest)
        {
            var result = await _socialMediaPlatformService.Delete(deleteSocialMediaPlatformRequest);
            return Ok(result);
        }
    }
}

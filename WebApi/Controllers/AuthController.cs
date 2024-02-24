using Business.Abstract;
using Business.Dtos.Request.CreateRequest;
using Core.Entities.Concrete;
using Core.Entities.Dtos;
using Core.Security.JWT;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        //[HttpPost("login")]
        //public ActionResult Login(UserForLoginDto userForLoginDto)
        //{
        //    var userToLogin = _authService.Login(userForLoginDto);
        //    if (!userToLogin.Success)
        //    {
        //        return BadRequest(userToLogin.Message);
        //    }

        //    var result = _authService.CreateAccessToken(userToLogin.Data);
        //    if (result.Success)
        //    {
        //        return Ok(result.Data);
        //    }

        //    return BadRequest(result.Message);
        //}

        //[HttpPost("register")]
        //public ActionResult Register(UserForRegisterDto userForRegisterDto)
        //{
        //    var userExists = _authService.UserExists(userForRegisterDto.Email);
        //    if (!userExists.Success)
        //    {
        //        return BadRequest(userExists.Message);
        //    }

        //    var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.Password);
        //    var result = _authService.CreateAccessToken(registerResult.Data);
        //    if (result.Success)
        //    {
        //        return Ok(result.Data);
        //    }

        //    return BadRequest(result.Message);
        //}



        //[HttpPost("passwordupdate")]
        //public ActionResult EmailForPasswordUpdate(UserForPasswordUpdate userForPasswordUpdate)
        //{
        //    var result = _authService.EmailForPasswordUpdate(userForPasswordUpdate.Email);
        //    if (!result.Success)
        //    {
        //        return Ok(result.Message);
        //    }
        //    return BadRequest(result.Message);
        //}

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserForLoginRequest userForLoginRequest)
        {
            var loginResult = await _authService.Login(userForLoginRequest);

            return Ok(loginResult);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserForRegisterRequest userForRegisterRequest)
        {
            var registerResult = await _authService.Register(userForRegisterRequest, userForRegisterRequest.Password);

            return Ok(registerResult);

        }

    }
}

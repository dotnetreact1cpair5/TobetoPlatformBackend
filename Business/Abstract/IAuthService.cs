using Business.Dtos.Request;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Response;
using Business.Dtos.Response.CreatedResponse;
using Core.Entities.Concrete;
using Core.Entities.Dtos;
using Core.Results;
using Core.Security.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService
    {

        Task<AccessToken> Register(UserForRegisterRequest userForRegisterRequest, string password);
        Task<AccessToken> Login(UserForLoginRequest userForLoginRequest);
        Task<AccessToken> CreateAccessToken(User user);
    }
}

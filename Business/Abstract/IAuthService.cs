﻿using Business.Dtos.Request;
using Business.Dtos.Response;
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

        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);

        IResult EmailForPasswordUpdate(string email);
    }
}
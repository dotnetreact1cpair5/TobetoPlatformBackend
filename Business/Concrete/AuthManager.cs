using AutoMapper;
using Business.Abstract;
using Business.Constants.Messages;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Business.Dtos.Response.CreatedResponse;
using Business.Rules;
using Core.DataAccess.Paging;
using Core.Entities.Concrete;
using Core.Entities.Dtos;
using Core.Results;
using Core.Security.Hashing;
using Core.Security.JWT;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;
        private IAccountDal _accountDal;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper, IAccountDal accountDal)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
            _accountDal = accountDal;
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _userService.Add(user);
            return new SuccessDataResult<User>(user, BusinessMessages.RegistrationSuccessfully);
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(BusinessMessages.UserOrEmailNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>(BusinessMessages.PasswordError);
            }

            return new SuccessDataResult<User>(userToCheck, BusinessMessages.SuccessfullEntry);
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return new ErrorResult(BusinessMessages.UserIsValid);
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, BusinessMessages.TokenCreated);
        }

       
        public IResult EmailForPasswordUpdate(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return new SuccessResult(BusinessMessages.PasswordResetLinkHasBeenSentToYourEmailAddress);
            }
            return new ErrorResult(BusinessMessages.ThisEmailAddressIsNotRegisteredInTheSystem);
        }

      
    }
}


using AutoMapper;
using Business.Abstract;
using Business.Constants.Messages;
using Business.Dtos.Request;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Response;
using Business.Dtos.Response.CreatedResponse;
using Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
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
        private IUserOperationClaimService _userOperationClaimService;
        private ITokenHelper _tokenHelper;
        private IMapper _mapper;

        public AuthManager(IUserService userService,IUserOperationClaimService userOperationClaimService, ITokenHelper tokenHelper,IMapper mapper)
        {
            _userService = userService;
            _userOperationClaimService = userOperationClaimService;
            _tokenHelper = tokenHelper;
            _mapper = mapper;
        }

        

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return new ErrorResult(BusinessMessages.UserIsValid);
            }
            return new SuccessResult();
        }

       

        public async Task<AccessToken> Register(UserForRegisterRequest userForRegisterRequest, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            User user = _mapper.Map<User>(userForRegisterRequest);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            var createdUser = await _userService.Add(user);

            var resultToken = await CreateAccessToken(createdUser);
            return resultToken;
        }

        public async Task<AccessToken> Login(UserForLoginRequest userForLoginRequest)
        {
            var userToCheck = await _userService.GetByMail(userForLoginRequest.Email);
            if (userToCheck == null)
            {
                throw new BusinessException(BusinessMessages.UserOrEmailNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginRequest.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                throw new BusinessException(BusinessMessages.PasswordError);
            }

            var resultToken = await CreateAccessToken(userToCheck);
            return resultToken;
        }

        public async Task<AccessToken> CreateAccessToken(User user)
        {
            var claims = await _userOperationClaimService.GetClaims(user.Id);
            var accessToken = await _tokenHelper.CreateToken(user, claims);
            return accessToken;
        }

    }
}


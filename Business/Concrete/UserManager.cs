using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.GetListResponse;
using Business.Dtos.Response.UpdatedResponse;
using Core.DataAccess.Dynamic;
using Core.DataAccess.Paging;
using Core.Entities.Concrete;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        IMapper _mapper;

        public UserManager(IUserDal userDal, IMapper mapper)
        {
            _userDal = userDal;
        }

        //public List<OperationClaim> GetClaims(User user)
        //{
        //    return _userDal.GetClaims(user);
        //}

        //public void Add(User user)
        //{
        //    _userDal.Add(user);
        //}

        //public User GetByMail(string email)
        //{
        //    return _userDal.Get(u => u.Email == email);
        //}

        public async Task<User> Add(User user)
        {

            User userCreated = await _userDal.AddAsync(user);
            // User userAuthMap = _mapper.Map<User>(userCreated);
            return userCreated;
        }

        public async Task<UpdatedUserResponse> Update(UpdateUserRequest updateUserRequest)
        {
            User user = _mapper.Map<User>(updateUserRequest);

            User userUpdated = await _userDal.UpdateAsync(user);

            UpdatedUserResponse updatedUserResponse = _mapper.Map<UpdatedUserResponse>(userUpdated);

            return updatedUserResponse;
        }

        public async Task<DeletedUserResponse> Delete(DeleteUserRequest deleteUserRequest)
        {
            User user = await _userDal.GetAsync(predicate: u => u.Id == deleteUserRequest.Id);

            User userDeleted = await _userDal.DeleteAsync(user, false);

            DeletedUserResponse deletedUserResponse = _mapper.Map<DeletedUserResponse>(userDeleted);

            return deletedUserResponse;
        }

        public async Task<User> GetByMail(string email)
        {
            User user = await _userDal.GetAsync(u => u.Email == email);
            var result = _mapper.Map<User>(user);
            return result;
        }

        public async Task<IPaginate<GetListUserResponse>> GetListAsync(PageRequest pageRequest)
        {
            var user = await _userDal.GetListAsync(
                    index: pageRequest.PageIndex,
                    size: pageRequest.PageSize);

            var result = _mapper.Map<Paginate<GetListUserResponse>>(user);
            return result;
        }



    }
}

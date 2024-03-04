using Business.Dtos.Request;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.GetListResponse;
using Business.Dtos.Response.UpdatedResponse;
using Core.DataAccess.Paging;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        Task<IPaginate<GetListUserResponse>> GetListAsync(PageRequest pageRequest);
        Task<User> Add(User user);
        Task<UpdatedUserResponse> Update(UpdateUserRequest updateUserRequest);
        Task<DeletedUserResponse> Delete(DeleteUserRequest deleteUserRequest);
        Task<User> GetByMail(string email);

    }
}

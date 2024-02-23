using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.GetListResponse;
using Business.Dtos.Response.UpdatedResponse;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAccountCourseService
    {
        Task<CreatedAccountCourseResponse> Add(CreateAccountCourseRequest createAccountCourse);
        Task<IPaginate<GetListAccountCourseResponse>> GetListAccountCourse();
        Task<UpdatedAccountCourseResponse> Update(UpdateAccountCourseRequest updateAccountCourse);
        Task<DeletedAccountCourseResponse> Delete(DeleteAccountCourseRequest deleteAccountCourse);
        Task<IPaginate<GetListAccountCourseResponse>> GetByUserId(int userId, PageRequest pageRequest);
        Task<IPaginate<GetListAccountCourseResponse>> GetByCourseId(int courseId);
    }
}

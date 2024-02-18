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
    public interface ICourseService
    {
        Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest);
        Task<IPaginate<GetListCourseResponse>> GetListCourse();
        Task<UpdatedCourseResponse> Update(UpdateCourseRequest updateCourseRequest);
        Task<DeletedCourseResponse> Delete(DeleteCourseRequest deleteCourseRequest);
        Task<IPaginate<GetListCourseResponse>> GetByCourseId(int courseId);
        Task<IPaginate<GetListCourseResponse>> GetByUserId(int userId);
    }
}

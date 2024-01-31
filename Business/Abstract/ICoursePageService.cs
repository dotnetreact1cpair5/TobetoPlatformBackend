using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICoursePageService
    {
        Task<CreatedCoursePageResponse> Add(CreateCoursePageRequest createCoursePageRequest);
        Task<IPaginate<GetListCoursePageResponse>> GetListCoursePage();
        Task<UpdatedCoursePageResponse> Update(UpdateCoursePageRequest updateCoursePageRequest);
        Task<DeletedCoursePageResponse> Delete(DeleteCoursePageRequest deleteCoursePageRequest);
        Task<GetListCoursePageResponse> GetById(int coursePaigeId);
    }
}

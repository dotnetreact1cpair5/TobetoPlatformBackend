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
    public interface ICourseCoursePageService
    {
        Task<CreatedCourseCoursePageResponse> Add(CreateCourseCoursePageRequest createCourseCoursePageRequest);
        Task<IPaginate<GetListCourseCoursePageResponse>> GetListCourseCoursePage();
        Task<UpdatedCourseCoursePageResponse> Update(UpdateCourseCoursePageRequest updateCourseCoursePageRequest);
        Task<DeletedCourseCoursePageResponse> Delete(DeleteCourseCoursePageRequest deleteCourseCoursePageRequest);
        Task<GetListCourseCoursePageResponse> GetById(int courseCoursePageId);
    }

}

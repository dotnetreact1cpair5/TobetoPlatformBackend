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
    public interface IContentCoursePageService
    {
        Task<CreatedContentCoursePageResponse> Add(CreateContentCoursePageRequest createContentCoursePageRequest);
        Task<IPaginate<GetListContentCoursePageResponse>> GetListContentCoursePage();
        Task<UpdatedContentCoursePageResponse> Update(UpdateContentCoursePageRequest updateContentCoursePageRequest);
        Task<DeletedContentCoursePageResponse> Delete(DeleteContentCoursePageRequest deleteContentCoursePageRequest);
        Task<GetListContentCoursePageResponse> GetById(int contentCoursePageId);
    }

}

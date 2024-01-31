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
    public interface ICoursePageLessonService
    {
        Task<CreatedCoursePageLessonResponse> Add(CreateCoursePageLessonRequest createCoursePageLessonRequest);
        Task<IPaginate<GetListCoursePageLessonResponse>> GetListCoursePageLesson();
        Task<UpdatedCoursePageLessonResponse> Update(UpdateCoursePageLessonRequest updateCoursePageLessonRequest);
        Task<DeletedCoursePageLessonResponse> Delete(DeleteCoursePageLessonRequest deleteCoursePageLessonRequest);
        Task<GetListCoursePageLessonResponse> GetById(int coursePaigeLessonId);
    }
}

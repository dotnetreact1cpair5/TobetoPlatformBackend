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
    public interface ILessonService
    {
        Task<CreatedLessonResponse> Add(CreateLessonRequest createLessonRequest);
        Task<IPaginate<GetListLessonResponse>> GetListLesson();
        Task<UpdatedLessonResponse> Update(UpdateLessonRequest updateLessonRequest);
        Task<DeletedLessonResponse> Delete(DeleteLessonRequest deleteLessonRequest);
    }
}

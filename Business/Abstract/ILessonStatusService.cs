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
    public interface ILessonStatusService
    {
        Task<CreatedLessonStatusResponse> Add(CreateLessonStatusRequest createLessonStatusRequest);
        Task<IPaginate<GetListLessonStatusResponse>> GetListLesson(PageRequest pageRequest);
        Task<UpdatedLessonStatusResponse> Update(UpdateLessonStatusRequest updateLessonStatusRequest);
        Task<DeletedLessonStatusResponse> Delete(DeleteLessonStatusRequest deleteLessonStatusRequest);
    }
}

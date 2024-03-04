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
    public interface ILessonStatuService
    {
        Task<CreatedLessonStatuResponse> Add(CreateLessonStatuRequest createLessonStatusRequest);
        Task<IPaginate<GetListLessonStatuResponse>> GetListLesson(PageRequest pageRequest);
        Task<UpdatedLessonStatuResponse> Update(UpdateLessonStatuRequest updateLessonStatusRequest);
        Task<DeletedLessonStatuResponse> Delete(DeleteLessonStatuRequest deleteLessonStatusRequest);
    }
}

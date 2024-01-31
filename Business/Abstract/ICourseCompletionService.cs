
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
    public interface ICourseCompletionService
    {
        Task<CreatedCourseCompletionResponse> Add(CreateCourseCompletionRequest createCourseCompletionRequest);
        Task<IPaginate<GetListCourseCompletionResponse>> GetListCourseCompletion();
        Task<UpdatedCourseCompletionResponse> Update(UpdateCourseCompletionRequest updateCourseCompletionRequest);
        Task<DeletedCourseCompletionResponse> Delete(DeleteCourseCompletionRequest deleteCourseCompletionRequest);
        Task<IPaginate<GetListCourseCompletionResponse>> GetById(int accountCourseCompletionId);
    }

}

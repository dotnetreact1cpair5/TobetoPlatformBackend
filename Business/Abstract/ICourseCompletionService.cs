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
    public interface ICourseCompletionService
    {
        Task<CreatedCourseCompletionResponse> Add(CreateCourseCompletionRequest createCourseCompletionRequest);
        Task<IPaginate<GetListCourseCompletionResponse>> GetListCourseCompletion();
        Task<UpdatedCourseCompletionResponse> Update(UpdateCourseCompletionRequest updateCourseCompletionRequest);
        Task<DeletedCourseCompletionResponse> Delete(DeleteCourseCompletionRequest deleteCourseCompletionRequest);
        Task<IPaginate<GetListCourseCompletionResponse>> GetById(int accountCourseCompletionId);
    }

}

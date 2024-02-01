using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.GetListResponse;
using Business.Dtos.Response.UpdatedResponse;
using Core.DataAccess.Paging;

namespace Business.Abstract
{
    public interface IApplicationStepService
    {
        Task<CreatedApplicationStepResponse> Add(CreateApplicationStepRequest createApplicationStepRequest);
        Task<UpdatedApplicationStepResponse> Update(UpdateApplicationStepRequest updateApplicationStepRequest);
        Task<DeletedApplicationStepResponse> Delete(DeleteApplicationStepRequest deleteApplicationStepRequest);
        Task<IPaginate<GetListApplicationStepResponse>> GetListApplicationStep(PageRequest pageRequest);
    }
}
